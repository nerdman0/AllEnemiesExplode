using RoR2;
//using R2API;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using static AllEnemiesExplode.Main;
using UnityEngine.AddressableAssets;
//using static AllEnemiesExplode.Log;
using AllEnemiesExplode;

namespace EntityStates.FuelArrayItem
{
    public class FuelArrayItemBaseState : BaseState
    {
        private protected CustomNetworkBehavior networkedBodyAttachment { get; private set; }//the networked body attachment

        private protected HealthComponent attachedHealthComponent { get; private set; }//the attached health component

        private protected CharacterModel attachedCharacterModel { get; private set; }//the attached character model

        private protected Transform[] displays { get; private set; } = Array.Empty<Transform>();//this isn't used

        private protected CustomItemDisplay customItemDisplay { get; private set; }//the custom item display attachment

        //set the above defined components
        public override void OnEnter()
        {
            base.OnEnter();
            this.networkedBodyAttachment = base.GetComponent<CustomNetworkBehavior>();
            this.customItemDisplay = base.GetComponent<CustomItemDisplay>();
            if (this.networkedBodyAttachment && this.networkedBodyAttachment.attachedBody)
            {
                this.attachedHealthComponent = this.networkedBodyAttachment.attachedBody.healthComponent;
                ModelLocator modelLocator = this.networkedBodyAttachment.attachedBody.modelLocator;
                if (modelLocator)
                {
                    Transform modelTransform = modelLocator.modelTransform;
                    if (modelTransform)
                    {
                        this.attachedCharacterModel = modelTransform.GetComponent<CharacterModel>();
                    }
                }
            }
        }
    }

    //=============================================================================================

    public class Monitor : FuelArrayItemBaseState
    {
        private float previousHealthFraction;//the previous ticks health fraction
        private static float healthFractionDetonationThreshold = 0.5f;//the health fraction at which the explosion should activate

        //make the base object and this object tick
        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (NetworkServer.active)
            {
                this.FixedUpdateServer();
            }
        }

        //when exiting this entitystate, if the deathoption is explode instant and the attached health component doesn't exist, go straight to the countdown state
        //this is to guarantee that wisps will detonate on explodeinstant when killed before reaching the countdown state, because otherwise they delete themselves on death instantly
        public override void OnExit()
        {
            if (WhatOnDeath.Value == DeathOptions.ExplodeInstant)
            {
                if (!this.attachedHealthComponent)
                {
                    this.outer.SetNextState(new CountDown());
                }
            }
        }

        private void FixedUpdateServer()
        {
            if (!base.attachedHealthComponent)//if there is no health component, do nothing
            {
                return;
            }
            float combinedHealthFraction = base.attachedHealthComponent.combinedHealthFraction;
            //if the current health is below the countdown threshold, and the previous ticks health isn't then detonate (this is done so the countdown only triggers once)
            if (combinedHealthFraction <= Monitor.healthFractionDetonationThreshold && Monitor.healthFractionDetonationThreshold < this.previousHealthFraction)
            {
                this.outer.SetNextState(new CountDown());
            }
            //set previous health fraction, so that on the next tick you can have what the previous tick used to be
            this.previousHealthFraction = combinedHealthFraction;
        }
    }

    //=============================================================================================

    public class CountDown : FuelArrayItemBaseState
    {
        public static float duration = 3f;//how long the countdown should be in seconds
        public static float explosionRadius = 30f;//the explosion radius
        private GameObject[] vfxInstances = Array.Empty<GameObject>();//each vfx instance
        private GameObject sphere;//the explosion indicated sphere object
        private AEXSphere[] spheres = Array.Empty<AEXSphere>();//each sphere instance
        private bool detonated;//if the fuel array has detonated

        public static GameObject vfxPrefab//the vfx prefab for the countdown
            = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/QuestVolatileBattery/VolatileBatteryPreDetonation.prefab").WaitForCompletion();

        public static GameObject explosionEffectPrefab//the explosion effect prefab
            = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/QuestVolatileBattery/VolatileBatteryExplosion.prefab").WaitForCompletion();

        public override void OnEnter()
        {
            //sets all the base class values
            base.OnEnter();
            //sets duration and explosion radius based on config values
            duration = AllEnemiesExplode.Main.SecondsToBoom.Value;
            explosionRadius = FixExplosionRadius.Value ? (30f/2f)/(4f/3f) : 30f;
            if (FixExplosionRadius.Value)
            {
                explosionRadius *= ExplosionSizeScalar.Value;
            }
            if (CountDown.vfxPrefab && base.customItemDisplay)
            {
                //if we are making explosion displays, then create a sphere object and apply the proper values to it
                if (EnableExplosionDisplay.Value)
                {
                    sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);//create sphere
                    var meshRenderer = sphere.GetComponent<MeshRenderer>();//get the mesh renderer for laater
                    Destroy(sphere.GetComponent<SphereCollider>());//remove the collider
                    sphere.AddComponent<AEXSphere>();//add an aexsphere component
                    sphere.transform.parent = base.networkedBodyAttachment.gameObject.transform;//set the parent to the cnb object
                    sphere.transform.localPosition = Vector3.zero;//zero the position
                    //cube.transform.localScale = Vector3.one * explosionRadius;//visual size of explosion
                    sphere.transform.localScale *= explosionRadius * 2;//actual size of explosion

                    meshRenderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;//turn of casting shadows
                    meshRenderer.receiveShadows = false;//turn of recieving shadows
                    meshRenderer.material = ExplosionIndicatorMaterial;//set the material to the one from the asset bundle
                    meshRenderer.material.color = new Color(RedChannel.Value/255f, GreenChannel.Value/255f, BlueChannel.Value/255f, Opacity.Value/100f);//set the rgba of the material
                }

                //get a list of all the display fuel array objects
                List<GameObject> equipmentDisplayObjects = base.customItemDisplay.customDisplays;
                if (equipmentDisplayObjects.Count > 0)
                {
                    //for each display create a countdown effect, and append the affect to the vfx instances list
                    this.vfxInstances = new GameObject[equipmentDisplayObjects.Count];
                    for (int i = 0; i < this.vfxInstances.Length; i++)
                    {
                        GameObject gameObject = global::UnityEngine.Object.Instantiate<GameObject>(CountDown.vfxPrefab, equipmentDisplayObjects[i].transform);
                        gameObject.transform.localPosition = Vector3.zero;
                        gameObject.transform.localRotation = Quaternion.identity;
                        this.vfxInstances[i] = gameObject;
                    }
                }
            }

            //if we somehow got to here without an attached health component and during instant explosion, cause an explosion (this should only happen in the above wisp edge case)
            if (!attachedHealthComponent && WhatOnDeath.Value == DeathOptions.ExplodeInstant)
            {
                detonated = true;
                Detonate();
            }
        }

        public override void OnExit()
        {
            //go through each countdown effect and remove it (otherwise it will keep ticking forever)
            GameObject[] array = this.vfxInstances;
            for (int i = 0; i < array.Length; i++)
            {
                EntityState.Destroy(array[i]);
            }
            this.vfxInstances = Array.Empty<GameObject>();

            //go through each aexsphere and remove it (if any)
            if (base.attachedCharacterModel)
            {
                this.spheres = base.attachedCharacterModel.GetComponentsInChildren<AEXSphere>();
                foreach(AEXSphere sphere in spheres)
                {
                    Destroy(sphere.gameObject);
                }
                this.spheres = Array.Empty<AEXSphere>();
            }

            //go through each custom display object and remove it
            foreach(GameObject customDisplay in base.customItemDisplay.customDisplays)
            {
                Destroy(customDisplay);
            }

            //if the countdown state is somehow being exited and we haven't exploded during instant explosions, explode 
            if(WhatOnDeath.Value == DeathOptions.ExplodeInstant)
            {
                if(!this.attachedHealthComponent.alive && !this.detonated)
                {
                    this.detonated = true;
                    this.Detonate();
                }
            }

            //exist the base class as well
            base.OnExit();
        }

        //tick the base and current classes
        public override void FixedUpdate()
        {
            base.FixedUpdate();
            if (NetworkServer.active)
            {
                this.FixedUpdateServer();
            }
        }

        private void FixedUpdateServer()
        {
            //if there is no health component (like a wisp, those darn wisps) and we haven't exploded, just keep waiting
            if (!this.attachedHealthComponent)
            {
                if (!this.detonated)
                {
                    if(WhatOnDeath.Value == DeathOptions.ExplodeDelay)
                    {
                        if(base.fixedAge >= CountDown.duration)
                        {
                            this.detonated = true;
                            this.Detonate();
                        }
                    }
                }
            }
            //if we are dead and haven't exploded, do one of 4 things
            else if (!this.attachedHealthComponent.alive && !this.detonated)
            {
                switch (WhatOnDeath.Value)
                {
                    case DeathOptions.Remove://either cancel the detonation by removing the countdown vfx and pretending we did explode
                        this.detonated = true;
                        OnExit();
                        break;
                    case DeathOptions.Normal://do nothing and let the stuff play out like normal
                        break;
                    case DeathOptions.ExplodeInstant://or just immediately explode
                        this.detonated = true;
                        this.Detonate();
                        break;
                    case DeathOptions.ExplodeDelay://this is here just for show mostly, the logic is on other parts of the script
                        break;
                }
            }

            //in case we aren't dead, just keep ticking
            if (base.fixedAge >= CountDown.duration && !this.detonated)
            {
                this.detonated = true;
                this.Detonate();
            }
        }

        public void Detonate()
        {
            //if we don't have a body, cancel ourselves since we can't explode
            if (!base.networkedBodyAttachment)
            {
                return;
            }

            //create a fake player gameobject
            GameObject tempFakePlayer = GameObject.Instantiate(FakePlayer);

            //instantiate attacker and team index
            GameObject tempAttacker;
            TeamIndex tempTeam;

            //set the explosion position to the cnb object
            Vector3 corePosition = base.networkedBodyAttachment.transform.position;

            //set a number to 3x the max health of our creature
            float num = base.networkedBodyAttachment.maxHealth * 3f;

            //increase explosion radius size
            /*if (FixExplosionRadius.Value)
            {
                explosionEffectPrefab.transform.localScale = Vector3.one*ExplosionSizeScalar.Value;
            } else
            {
                explosionEffectPrefab.transform.localScale = Vector3.one;
            }*/

            //changes values of attacker and team based on if explosion should give money or not
            if (ExplosionGivesMoney.Value)
            {
                tempFakePlayer.GetComponent<CharacterBody>().teamComponent.teamIndex = TeamIndex.Player;
                tempAttacker = tempFakePlayer;
                tempTeam = TeamIndex.Player;
            } else
            {
                tempAttacker = base.networkedBodyAttachment.attachedBodyObject;
                tempTeam = base.networkedBodyAttachment.attachedBody.teamComponent.teamIndex;
            }

            //create an explosion visual effect
            EffectManager.SpawnEffect(CountDown.explosionEffectPrefab, new EffectData
            {
                origin = corePosition,
                scale = CountDown.explosionRadius
            }, true);

            //create an explosion with all the necessary stats, then fire the explosion
            new BlastAttack
            {
                position = corePosition + global::UnityEngine.Random.onUnitSphere,
                radius = CountDown.explosionRadius,
                falloffModel = BlastAttack.FalloffModel.None,
                attacker = tempAttacker,
                inflictor = base.networkedBodyAttachment.gameObject,
                damageColorIndex = DamageColorIndex.Item,
                baseDamage = num,
                baseForce = 5000f,
                bonusForce = Vector3.zero,
                attackerFiltering = AttackerFiltering.AlwaysHit,
                crit = false,
                procChainMask = default(ProcChainMask),
                procCoefficient = 0f,
                teamIndex = tempTeam
            }.Fire();

            //if the body still exists, remove the fuel array from it
            if (base.networkedBodyAttachment.attachedBody)
            {
                if (base.networkedBodyAttachment.attachedBody.inventory)
                {
                    base.networkedBodyAttachment.attachedBody.inventory.RemoveItemPermanent(AllEnemiesExplode.Main.FuelArrayItem, base.networkedBodyAttachment.attachedBody.inventory.GetItemCountPermanent(AllEnemiesExplode.Main.FuelArrayItem));
                }
            }

            //remove the fake player
            Destroy(tempFakePlayer);

            //if we were using explodeinstant or explodedelay then we can finally remove the cnb gameobject (since we cancelled the removal before)
            if (WhatOnDeath.Value == DeathOptions.ExplodeInstant || WhatOnDeath.Value == DeathOptions.ExplodeDelay)
            {
                Destroy(base.networkedBodyAttachment.gameObject);
            }

            //go to the idle state
            this.outer.SetNextState(new Idle());
        }
    }

    //a component given to explosion indicator spheres to make it easier to find them
    public class AEXSphere : MonoBehaviour { }
}
