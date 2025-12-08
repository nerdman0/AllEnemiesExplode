using BepInEx;
using BepInEx.Configuration;
using EntityStates;
using MonoMod.Cil;
using Mono.Cecil.Cil;
using R2API;
using RiskOfOptions;
using RiskOfOptions.OptionConfigs;
using RiskOfOptions.Options;
using RoR2;
//using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Numerics;
//using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
//using static EntityStates.FuelArrayItem.AEXSphere;
//using static RoR2.GenericPickupController;
using Path = System.IO.Path;

namespace AllEnemiesExplode
{
    //add risk of options as a dependancy for that cool built in config editor
    [BepInDependency("com.rune580.riskofoptions")]

    //Since I'm creating a custom item it's probably a good idea to use the item api
    [BepInDependency(ItemAPI.PluginGUID)]

    //If I want to be able to translate my mod lets just use the language api too
    [BepInDependency(LanguageAPI.PluginGUID)]

    // This attribute is required, and lists metadata for your plugin.
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]

    // This is the main declaration of our plugin class.
    // BepInEx searches for all classes inheriting from BaseUnityPlugin to initialize on startup.
    // BaseUnityPlugin itself inherits from MonoBehaviour,
    // so you can use this as a reference for what you can declare and use in your plugin class
    // More information in the Unity Docs: https://docs.unity3d.com/ScriptReference/MonoBehaviour.html
    public class Main : BaseUnityPlugin
    {
        //Create a variable to access the plugin info
        public static BepInEx.PluginInfo PInfo { get; private set; }
        //Create an asset bundle variable to load the asset bundle into
        public static AssetBundle mainBundle;
        //This variable holds the name of the asset bundle
        public const string bundleName = "explosion_indicator_material";
        // Uncomment this if your assetbundle is in its own folder. Of course, make sure the name of the folder matches this.
        public const string assetBundleFolder = "assetbundles";

        //the asset bundle path variable
        public static string AssetBundlePath
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(PInfo.Location), assetBundleFolder, bundleName);
            }
        }

        //set the mod name, author name, and the mod version
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "Nerdman";
        public const string PluginName = "AllEnemiesExplode";
        public const string PluginVersion = "1.0.4";

        //Define the config values
        public static ConfigEntry<float> SecondsToBoom;
        public static ConfigEntry<DeathOptions> WhatOnDeath;
        public static ConfigEntry<bool> ExplosionGivesMoney;
        public static ConfigEntry<bool> FixExplosionRadius;
        public static ConfigEntry<float> ExplosionSizeScalar;
        public static ConfigEntry<bool> EnableItemDisplay;
        public static ConfigEntry<bool> EnableExplosionDisplay;
        public static ConfigEntry<float> RedChannel;
        public static ConfigEntry<float> GreenChannel;
        public static ConfigEntry<float> BlueChannel;
        public static ConfigEntry<float> Opacity;
        public static ConfigEntry<bool> Snek;

        //Define the explosion indicator material
        public static Material ExplosionIndicatorMaterial;

        //Define your custom items
        public static ItemDef FuelArrayItem;

        //Define a fuel array item prefab
        public static GameObject FuelArrayItemPrefab;

        //Define a fuel array model gameobject reference
        public static GameObject FuelArrayModel;

        //Define a fake player
        public static GameObject FakePlayer;

        //Define explosion effect prefab
        public static GameObject ExplosionFX;

        // The Awake() method is run at the very start when the game is initialized.
        public void Awake()
        {
            //set the pinfo
            PInfo = Info;

            //set the assetbundle
            mainBundle = AssetBundle.LoadFromFile(AssetBundlePath);

            //initialize the logger
            Log.Init(Logger);

            //Set material to instance of material from assetbundle
            ExplosionIndicatorMaterial = mainBundle.LoadAsset<Material>("explosion_indicator_material.mat");

            //Set the item to an instance so we can edit it
            FuelArrayItem = ScriptableObject.CreateInstance<ItemDef>();

            //Language tokens for localization of text fields
            FuelArrayItem.name = "FuelArrayItem";
            FuelArrayItem.nameToken = "FuelArrayItem";
            FuelArrayItem.pickupToken = "FuelArrayItemPickup";
            FuelArrayItem.descriptionToken = "FuelArrayItemDescription";
            FuelArrayItem.loreToken = "FuelArrayItemLore";

            //The fuel array item is hidden from the player can cannot be removed
            FuelArrayItem.canRemove = false;
            FuelArrayItem.hidden = false;

            //Set item tier to untiered
            FuelArrayItem.tier = ItemTier.NoTier;
#pragma warning disable CS0618 //"Type or member is obsolete" bitch stfu it needs to be here either way
            FuelArrayItem.deprecatedTier = ItemTier.NoTier;
#pragma warning restore CS0618

            //Give the item a model for when it is on the floor and in the inventory
            FuelArrayItem.pickupIconSprite = Addressables.LoadAssetAsync<Sprite>("RoR2/Base/QuestVolatileBattery/texBatteryArrayIcon.png").WaitForCompletion();
#pragma warning disable CS0618 //don't think you're safe too mf
            //FuelArrayItem.pickupModelPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/QuestVolatileBattery/DisplayBatteryArray.prefab").WaitForCompletion();
#pragma warning restore CS0618

            //store the fuel array model as a variable, for later...
            FuelArrayModel = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/QuestVolatileBattery/DisplayBatteryArray.prefab").WaitForCompletion();
            
            //get an enemy character to store as a fake player
            FakePlayer = PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>("RoR2/Base/Commando/CommandoBody.prefab").WaitForCompletion(), "FakePlayerShitlips");
            FakePlayer.GetComponent<CharacterBody>().teamComponent = FakePlayer.GetComponent<TeamComponent>();
            FakePlayer.GetComponent<CharacterBody>().teamComponent.teamIndex = TeamIndex.None;

            //get the damn explosion effect or i am going to fucking die
            ExplosionFX = PrefabAPI.InstantiateClone(Addressables.LoadAssetAsync<GameObject>("RoR2/Base/QuestVolatileBattery/VolatileBatteryExplosion.prefab").WaitForCompletion(), "ExplosionEffectClone");

            //Add idrs for enemies missing them
            IDRD.AddDisplayRuleset();

            //Add children needed for display rules
            IDRD.AddChildren();

            //Add the fuel array item into the item registry
            ItemAPI.Add(new CustomItem(FuelArrayItem, IDRD.ItemDisplayTransformations()));

            //add entitystates for the fuel array item
            bool temptorary;
            ContentAddition.AddEntityState<EntityStates.FuelArrayItem.FuelArrayItemBaseState>(out temptorary);
            ContentAddition.AddEntityState<EntityStates.FuelArrayItem.Monitor>(out temptorary);
            ContentAddition.AddEntityState<EntityStates.FuelArrayItem.CountDown>(out temptorary);

            //Add the fuel array item prefab
            FuelArrayItemPrefab = PrefabAPI.InstantiateClone(LegacyResourcesAPI.Load<GameObject>("Prefabs/NetworkedObjects/QuestVolatileBatteryAttachment"), "FuelArrayItemAttachment");
            FuelArrayItemPrefab.GetComponent<EntityStateMachine>().initialStateType = new SerializableEntityStateType(typeof(EntityStates.FuelArrayItem.Monitor));
            FuelArrayItemPrefab.GetComponent<EntityStateMachine>().mainStateType = new SerializableEntityStateType(typeof(EntityStates.FuelArrayItem.Monitor));
            FuelArrayItemPrefab.AddComponent<CustomNetworkBehavior>();
            Destroy(FuelArrayItemPrefab.GetComponent<NetworkedBodyAttachment>());

            //go ahead, make my config
            Init();

            //hooks, hooks, get your hooks here
            Hooks();

        }

        public void Init()
        {
            //bind the configs to actual configs
            SecondsToBoom = Config.Bind<float>("Mod: " + PluginName, "Enemy explosion delay:", 3f, "How long in seconds should it take for the enemy to explode after reaching the explosion threshold\n(Default: 3)");
            WhatOnDeath = Config.Bind<DeathOptions>("Mod: " + PluginName, "Fuel array action on death:", DeathOptions.ExplodeDelay, "What should happen to the fuel array when the enemy holding it dies\n(Default: ExplodeDelay)\n\n" +
                "Remove: Stops the explosion from hapenning at all\n" +
                "Normal: Runs normally (gives unpredictable results, but most stable)\n" +
                "ExplodeInstant: The enemy explodes instantly on death (Wisps are bugged)\n" +
                "ExplodeDelay: The enemy explodes after the fuel array timer reaches 0");
            ExplosionGivesMoney = Config.Bind<bool>("Mod: " + PluginName, "Explosions give money:", true, "Should enemy explosions give the player money?\n(Default: true)");
            FixExplosionRadius = Config.Bind<bool>("Mod: " + PluginName, "Fix explosion radius:", false, "Due to some oversights in the original code the explosion radius is nearly three times larger that what it visually looks like it should be, this fixes that\n(Default: false)");
            ExplosionSizeScalar = Config.Bind<float>("Mod: " + PluginName, "Explosion size scalar:", 1f, "How many times bigger should the explosion be (scales explosion vfx)\n(Default: 1)");
            EnableItemDisplay = Config.Bind<bool>("Mod: " + PluginName, "Display item display:", true, "Enable the fuel array to be visible on the enemies themselves. Setting this to false also disables the countdown effect\n(Default: true)");
            EnableExplosionDisplay = Config.Bind<bool>("Mod: " + PluginName, "Display explosion radius:", false, "Enable a visual indicator for the explosion radius of the fuel array\n(Default: false)");
            RedChannel = Config.Bind<float>("Mod: " + PluginName, "Red:", 255f, "Controls the red channel of the color indicator sphere\n(Default: 255)");
            GreenChannel = Config.Bind<float>("Mod: " + PluginName, "Green:", 127f, "Controls the green channel of the color indicator sphere\n(Default: 127)");
            BlueChannel = Config.Bind<float>("Mod: " + PluginName, "Blue:", 0f, "Controls the blue channel of the color indicator sphere\n(Default: 0)");
            Opacity = Config.Bind<float>("Mod: " + PluginName, "Opacity:", 8f, "Controls the opacity of the color indicator sphere\n(Default: 8)");
            Snek = Config.Bind<bool>("Mod: " + PluginName, "Anti-Snek measures:", false, "Using ion surge makes you explode\n(Default: false)");

            CoolerInit();//bind the config to risk of options
        }

        public void CoolerInit()
        {
            //set up entries in the risk of options settings
            ModSettingsManager.AddOption(new StepSliderOption(SecondsToBoom, new StepSliderConfig() { min = 0f, max = 15f, increment = 0.1f }));
            ModSettingsManager.AddOption(new ChoiceOption(WhatOnDeath));
            ModSettingsManager.AddOption(new CheckBoxOption(ExplosionGivesMoney));
            ModSettingsManager.AddOption(new CheckBoxOption(FixExplosionRadius));
            ModSettingsManager.AddOption(new StepSliderOption(ExplosionSizeScalar, new StepSliderConfig() { min = 0f, max = 10f, increment = 0.1f, checkIfDisabled = SizeFixer }));
            ModSettingsManager.AddOption(new CheckBoxOption(EnableItemDisplay));
            ModSettingsManager.AddOption(new CheckBoxOption(EnableExplosionDisplay));
            ModSettingsManager.AddOption(new StepSliderOption(RedChannel, new StepSliderConfig() { min = 0f, max = 255f, increment = 1f, checkIfDisabled = VisualizerEnabled }));
            ModSettingsManager.AddOption(new StepSliderOption(GreenChannel, new StepSliderConfig() { min = 0f, max = 255f, increment = 1f, checkIfDisabled = VisualizerEnabled }));
            ModSettingsManager.AddOption(new StepSliderOption(BlueChannel, new StepSliderConfig() { min = 0f, max = 255f, increment = 1f, checkIfDisabled = VisualizerEnabled }));
            ModSettingsManager.AddOption(new StepSliderOption(Opacity, new StepSliderConfig() { min = 0f, max = 255f, increment = 1f, checkIfDisabled = VisualizerEnabled }));
            ModSettingsManager.AddOption(new CheckBoxOption(Snek));
        }

        public enum DeathOptions//the different options for what to do if the enemy dies before exploding
        {
            Remove,
            Normal,
            ExplodeInstant,
            ExplodeDelay
        }

        private bool SizeFixer()//used for enabling/disabling the explosion size scalar
        {
            return !FixExplosionRadius.Value;
        }

        private bool VisualizerEnabled()//used for enabling/disabling the explosion visualizer customization
        {
            return !EnableExplosionDisplay.Value;
        }

        public void Hooks()//add hooks onto some methods/events
        {
            SpawnCard.onSpawnedServerGlobal += AddExplosivePayload;
            On.RoR2.ScriptedCombatEncounter.Spawn += AddScriptedExplosivePayload;
            On.RoR2.CharacterMaster.SpawnBodyHere += AddSpawnBodyExplosivePayload;
            On.RoR2.CharacterBody.OnInventoryChanged += CharacterBody_OnInventoryChanged;
            On.EntityStates.Mage.FlyUpState.OnEnter += AntiSnek;
            IL.EntityStates.VoidInfestor.Infest.FixedUpdate += DontCountInfest;
            //On.EntityStates.QuestVolatileBattery.CountDown.Detonate += FixExplosion;
        }

        private void AddExplosivePayload(SpawnCard.SpawnResult spawnResult)
        {
            //get the character master of the spawned enemy
            CharacterMaster characterMaster = (spawnResult.spawnedInstance ? spawnResult.spawnedInstance.GetComponent<CharacterMaster>() : null);
            //if there is no charactermaster, or the spawned enemy isn't an enemy, cancel
            if (!characterMaster)
            {
                return;
            }
            if (characterMaster.teamIndex != TeamIndex.Monster)
            {
                return;
            }
            //otherwise, put a fuel array item into their inventory
            characterMaster.inventory.GiveItemPermanent(FuelArrayItem);
        }

        private void AddScriptedExplosivePayload(On.RoR2.ScriptedCombatEncounter.orig_Spawn orig, ScriptedCombatEncounter self, ref ScriptedCombatEncounter.SpawnInfo spawnInfo)
        {
            //when an ambush happens, check if it uses character spawn cards
            if (spawnInfo.spawnCard.GetType() == typeof(CharacterSpawnCard))
            {
                CharacterSpawnCard csc = (CharacterSpawnCard)spawnInfo.spawnCard;
                List<ItemCountPair> itemsToGrantVector = new List<ItemCountPair>();
                ItemCountPair oneFuelArrayItem = new ItemCountPair
                {
                    itemDef = FuelArrayItem,
                    count = 1
                };

                //add each item to grant in the character spawn card list into a vector
                foreach (ItemCountPair itemPair in csc.itemsToGrant)
                {
                    itemsToGrantVector.Add(itemPair);
                }

                //add one more item to the vector (the fuel array item)
                itemsToGrantVector.Add(oneFuelArrayItem);

                //then turn the vector into a list and pass it into the character spawn card
                csc.itemsToGrant = itemsToGrantVector.ToArray();

                //run the rest of the method
                orig(self, ref spawnInfo);

                //reset the items to grant vector
                itemsToGrantVector = new List<ItemCountPair>();

                //go through all the items again
                foreach (ItemCountPair itemPair in csc.itemsToGrant)
                {
                    //if the item count pair isn't the fuel array, then pass it through
                    if(!itemPair.Equals(oneFuelArrayItem))
                    {
                        itemsToGrantVector.Add(itemPair);
                    }
                }

                //turn the vector into a list and pass it into the character spawn card, hunky dory
                csc.itemsToGrant = itemsToGrantVector.ToArray();
            }
        }
        
        private void AddSpawnBodyExplosivePayload(On.RoR2.CharacterMaster.orig_SpawnBodyHere orig, CharacterMaster self)
        {
            //if something is spawned with spawnbodyhere and it has an inventory, give it a fuel array
            if (self.inventory)
            {
                self.inventory.GiveItemPermanent(FuelArrayItem);
            }
            orig(self);
        }
        
        private void AntiSnek(On.EntityStates.Mage.FlyUpState.orig_OnEnter orig, EntityStates.Mage.FlyUpState self)
        {
            //if anti snek is on
            if (Snek.Value)
            {
                //get the player position and load the explosion effect prefab
                UnityEngine.Vector3 corePosition = self.gameObject.transform.position;
                GameObject explosionEffectPrefab//the explosion effect prefab
                    = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/QuestVolatileBattery/VolatileBatteryExplosion.prefab").WaitForCompletion();

                //spawn the explosion effect
                EffectManager.SpawnEffect(explosionEffectPrefab, new EffectData
                {
                    origin = corePosition,
                    scale = FixExplosionRadius.Value ? ((30f/2f)/(4f/3f))*ExplosionSizeScalar.Value : 30f
                }, true);

                //create an explosion blast equivalent to that of the fuel array
                new BlastAttack
                {
                    position = corePosition + global::UnityEngine.Random.onUnitSphere,
                    radius = FixExplosionRadius.Value ? ((30f/2f)/(4f/3f))*ExplosionSizeScalar.Value : 30f,
                    falloffModel = BlastAttack.FalloffModel.None,
                    attacker = self.characterBody.gameObject,//if explosions give money, set attacker to fake player
                    inflictor = self.characterBody.gameObject,
                    damageColorIndex = DamageColorIndex.Item,
                    baseDamage = self.healthComponent.fullCombinedHealth*3f,
                    baseForce = 5000f,
                    bonusForce = UnityEngine.Vector3.zero,
                    attackerFiltering = AttackerFiltering.AlwaysHit,
                    crit = false,
                    procChainMask = default(ProcChainMask),
                    procCoefficient = 0f,
                    teamIndex = self.characterBody.teamComponent.teamIndex
                }.Fire();

                //to make sure the player dies, make the player kill themselves
                self.healthComponent.Suicide();

                //send a quick chat message to goad snek ehehehe
                Chat.SendBroadcastChat(new Chat.SubjectFormatChatMessage
                {
                    subjectAsCharacterBody = self.characterBody,
                    baseToken = "SnekGoading"
                });
            }

            orig(self);
        }

        private void DontCountInfest(ILContext il)
        {
            //do il cursor stuff idk
            ILCursor c = new ILCursor(il);
            //go to the first healthcomponent suicide call
            c.GotoNext(i => i.MatchCallOrCallvirt<HealthComponent>("Suicide"));
            //delete the call
            c.Remove();
            //remove all values in the il stack since we won't use them but the stack needs to be balanced
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Pop);
            c.Emit(OpCodes.Pop);
            //load "this"
            c.Emit(OpCodes.Ldarg_0);
            //put in the following code
            c.EmitDelegate((EntityStates.VoidInfestor.Infest self) =>
            {
                //get the fuel array item behavior component
                FuelArrayItemBehavior fuelArrayItemBehavior = self.gameObject.GetComponent<FuelArrayItemBehavior>();
                if (fuelArrayItemBehavior)
                {
                    //check to see if the attachment exists
                    if (fuelArrayItemBehavior.attachment)
                    {
                        //if it does, delete it
                        Destroy(fuelArrayItemBehavior.attachment.gameObject);
                    }
                }
                //then KILL YOURSELF *thunder*
                self.healthComponent.Suicide(null, null, default(DamageTypeCombo));
            });
        }

        private void CharacterBody_OnInventoryChanged(On.RoR2.CharacterBody.orig_OnInventoryChanged orig, CharacterBody self)
        {
            if (NetworkServer.active)
            {
                //when the inventory changes, if there is a fuel array item then add the proper item behavior
                self.AddItemBehavior<FuelArrayItemBehavior>(self.inventory.GetItemCountPermanent(FuelArrayItem));
            }
            orig(self);
        }

        //reset explosion vfx size for normal explosion
        /*private void FixExplosion(On.EntityStates.QuestVolatileBattery.CountDown.orig_Detonate orig, EntityStates.QuestVolatileBattery.CountDown self)
        {
            Addressables.LoadAssetAsync<GameObject>("RoR2/Base/QuestVolatileBattery/VolatileBatteryExplosion.prefab").WaitForCompletion().transform.localScale = Vector3.one;
            orig(self);
        }*/
    }

    //dih
    public class DihChoppedOff : MonoBehaviour { }
}