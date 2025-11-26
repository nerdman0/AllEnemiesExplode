using RoR2;
using R2API;
using UnityEngine;
using RoR2BepInExPack.GameAssetPathsBetter;

namespace AllEnemiesExplode
{

    public static class IDRD
    {
        //private AssetReferenceGameObject itemDisplayAsset = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab);
        public static ItemDisplayRuleDict ItemDisplayTransformations()
        {
            ItemDisplayRuleDict val = new ItemDisplayRuleDict((ItemDisplayRule[])null);

            //Larva
            val.Add("AcidLarva", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, -2.75F, 0.5F),
                    localAngles = new Vector3(300F, 355F, 0F),
                    localScale = new Vector3(5.5F, 5.5F, 5.5F)
                }
            });

            //Healing Core needs more children, get to fuckin'
            val.Add("mdlEliteMendingSphere", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "ChargeUpFX",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Ancient Wisp
            val.Add("mdlAncientWisp", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "FireMain",
                    localPos = new Vector3(0F, -0.35F, 1.5F),
                    localAngles = new Vector3(70F, 0F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)
                }
            });

            //Archwisp
            val.Add("mdlArchWisp", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, 0F, -1.5F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Artifact Reliquary
            val.Add("ArtifactShellModel", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "PP",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Assassin
            val.Add("mdlAssassin", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(-0.15F, -0.25F, -0.07F),
                    localAngles = new Vector3(75F, 180F, 180F),
                    localScale = new Vector3(0.6F, 0.6F, 0.6F)
                }
            });

            //Engineer
            val.Add("mdlRoboAssassin", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "SwingCenter",
                    localPos = new Vector3(0F, 0.15F, -0.13F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.25F, 0.25F, 0.25F)
                }
            });

            //Strike Drone
            val.Add("mdlBackupDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, 0.95F, 0F),
                    localAngles = new Vector3(270F, 0F, 0F),
                    localScale = new Vector3(0.9F, 0.9F, 0.9F)
                }
            });

            //Drone Backup
            val.Add("mdlDroneBackup", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, -0.25F, 0.3F),
                    localAngles = new Vector3(270F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Bandit
            val.Add("mdlBandit2", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.07F, 0.252F, -0.291F),
                    localAngles = new Vector3(342.9198F, 167.6784F, 3.670728F),
                    localScale = new Vector3(0.3494F, 0.3494F, 0.3494F)
                }
            });

            //Bandit (Again?) (Actually this is old bandit)
            val.Add("mdlBandit", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0.38F, 0F),
                    localAngles = new Vector3(287F, 180F, 180F),
                    localScale = new Vector3(0.35F, 0.35F, 0.35F)
                }
            });

            //Heat Vent
            val.Add("mdlPod", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HealthBarOrigin",
                    localPos = new Vector3(0F, 0F, -0.05F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Beetle
            val.Add("mdlBeetle", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.02F, 0.15F, -0.85F),
                    localAngles = new Vector3(0F, 180F, 180F),
                    localScale = new Vector3(0.75F, 0.75F, 0.75F)
                }
            });

            //Beetle Guard
            val.Add("mdlBeetleGuard", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, -0.63F, 2.2F),
                    localAngles = new Vector3(300F, 0F, 0F),
                    localScale = new Vector3(2F, 2F, 2F)
                }
            });

            //Beetle Queen
            val.Add("mdlBeetleQueen", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Stomach",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(4F, 4F, 4F)
                }
            });

            //Beetle Ward
            /*val.Add("mdlBeetleWard", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Brass Contraption
            val.Add("mdlBell", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chain",
                    localPos = new Vector3(0F, 2F, 0F),
                    localAngles = new Vector3(90F, 330F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Bighorn Bison
            val.Add("mdlBison", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0F, 1.2F),
                    localAngles = new Vector3(270F, 0F, 0F),
                    localScale = new Vector3(0.7F, 0.7F, 0.7F)
                }
            });

            //Bombardment Drone
            val.Add("mdlBombardmentDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(270F, 0F, 0F),
                    localScale = new Vector3(0.9F, 0.9F, 0.9F)
                }
            });

            //Bomber
            val.Add("mdlCommandoDualies", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0.347F, -0.309F),
                    localAngles = new Vector3(342.5413F, 180F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Mithrix
            val.Add("mdlBrother", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MuzzleUlt",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Captain
            val.Add("mdlCaptain", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(-0.004F, 0.152F, -0.306F),
                    localAngles = new Vector3(9.601077F, 359.9617F, 179.5275F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //CHEF
            val.Add("mdlChef", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.185F, -0.006F, 0.41F),
                    localAngles = new Vector3(358.8724F, 180F, 0F),
                    localScale = new Vector3(0.335028F, 0.335028F, 0.335028F)
                }
            });

            //Child
            val.Add("mdlChild", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, -0.2F, 0.17F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.6F, 0.6F, 0.6F)
                }
            });

            //Clay Man
            val.Add("mdlClay", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Shield",
                    localPos = new Vector3(0F, 0F, -0.16F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Clay Dunestrider
            val.Add("mdlClayBoss", (ItemDisplayRule[])(object)new ItemDisplayRule[2]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Center",
                    localPos = new Vector3(2.36F, 0.03F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Center",
                    localPos = new Vector3(-2.36F, 0.03F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)
                }
            });

            //Clay Templar
            val.Add("mdlClayBruiser", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0.5F, 0.08F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Clay Apothecary
            val.Add("mdlClayGrenadier", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Torso",
                    localPos = new Vector3(0F, 0.11F, 0.46F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.25F, 0.25F, 0.25F)
                }
            });

            //Cleanup Drone
            val.Add("mdlCleanupDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(-0.7F, 0.2F, 0.7F),
                    localAngles = new Vector3(0F, 315F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Freeze Drone
            val.Add("mdlCopycatDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Scanner",
                    localPos = new Vector3(0F, 0F, 0.05F),
                    localAngles = new Vector3(0F, 90F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Lunar Rain
            /*val.Add("Mesh", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Acrid
            val.Add("mdlCroco", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(-0.01F, -0.16F, 4.03F),
                    localAngles = new Vector3(24.60086F, 359.8272F, 179.4876F),
                    localScale = new Vector3(2.5F, 2.5F, 2.5F)
                }
            });

            //CROSSHAIRS
            val.Add("mdlGunnerDroneDT", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, -1.65F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //CHIRP
            val.Add("mdlDTHaulerDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, 0.4F, 0F),
                    localAngles = new Vector3(270F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //DOC
            val.Add("mdlHealingDroneDT", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, -0.3F, -0.5F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1.1F, 1.1F, 1.1F)
                }
            });

            //Solus Invalidator
            val.Add("mdlDefectiveUnit (1)", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, 0F, 0.08F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Lemurian
            val.Add("mdlLemurian", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, -1F, 2.17F),
                    localAngles = new Vector3(343F, 180F, 180F),
                    localScale = new Vector3(3F, 3F, 3F)
                }
            });

            //Elder Lemurian
            val.Add("mdlLemurianBruiser", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 2F),
                    localAngles = new Vector3(15F, 0F, 0F),
                    localScale = new Vector3(2.5F, 2.5F, 2.5F)
                }
            });

            //Drifter
            val.Add("mdlDrifter", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "BagFrontPocket",
                    localPos = new Vector3(0.325F, 0.333F, 0.309F),
                    localAngles = new Vector3(331.3243F, 49.68224F, 214.8985F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Shield Tank
            /*val.Add("mshBase", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "IntactTube",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Gunner Drone
            val.Add("mdlDrone1", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, -1.65F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Healing Drone
            val.Add("mdlDrone2", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, -0.3F, -0.5F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1.1F, 1.1F, 1.1F)
                }
            });

            //Col. Droneman
            val.Add("mdlDroneCommander", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, -0.07F, -0.2F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)
                }
            });

            //Operator
            val.Add("mdlDroneTech", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(-0.2248F, 0.0006F, 0.002F),
                    localAngles = new Vector3(354.1241F, 269.9885F, 180.3767F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)
                }
            });

            //Overloading Worm
            val.Add("mdlMagmaWorm", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "LowerJaw",
                    localPos = new Vector3(0F, 1F, 0.2F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Emergency Drone
            val.Add("mdlEmergencyDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, -1.3F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(2.5F, 2.5F, 2.5F)
                }
            });

            //Engineer Turret
            val.Add("mdlEngiTurret", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, 0.5F, -1F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)//for some reason item display for this is broken
                }
            });

            //Engineer
            val.Add("mdlEngi", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.009F, 0.479F, -0.397F),
                    localAngles = new Vector3(27.75807F, 357.5244F, 178.011F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Engineer Turret
            val.Add("mdlEngiWalkerTurret", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, 0F, -1.35F),
                    localAngles = new Vector3(340F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Equipment Drone
            val.Add("mdlEquipmentDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "GunAxis",
                    localPos = new Vector3(0.023F, 2.338F, -0.001F),
                    localAngles = new Vector3(89.7815F, 36.67846F, 36.70512F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Memory Module
            val.Add("mdlSolusWingEyeTube", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, 0F, -3F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(2.75F, 2.75F, 2.75F)
                }
            });

            //JUNKBOMB_BODY_NAME
            /*val.Add("mdlJunkDrone_Mine_Prop", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Solus Extractor
            val.Add("mdlExtractorUnit", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Center",
                    localPos = new Vector3(0F, 1.5F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //False Son
            val.Add("mdlFalseSon", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0.49F, -0.405F),
                    localAngles = new Vector3(330.9604F, 180F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Coolant Distributor
            val.Add("mdlFireExtinguisherPod", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HealthBarOrigin",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Incinerator Drone
            val.Add("mdlFlameDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Eye",
                    localPos = new Vector3(0F, 0F, -0.75F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(2F, 2F, 2F)
                }
            });

            //Blind Pest
            val.Add("mdlFlyingVermin", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Body",
                    localPos = new Vector3(0F, 0.55F, -0.9F),
                    localAngles = new Vector3(20F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Geep
            val.Add("mdlGeep", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0.69F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Gip
            val.Add("mdlGip", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0.69F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Stone Golem
            val.Add("mdlGolem", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0.5F, 0.1F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Grandparent
            val.Add("mdlGrandparent", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 8F, 0F),
                    localAngles = new Vector3(13F, 0F, 0F),
                    localScale = new Vector3(7F, 7F, 7F)
                }
            });

            //Grovetender
            val.Add("mdlGravekeeper", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MuzzleJar",
                    localPos = new Vector3(-0.1F, -4.75F, -0.16F),
                    localAngles = new Vector3(80F, 270F, 325F),
                    localScale = new Vector3(4F, 4F, 4F)
                }
            });

            //Greater Wisp
            val.Add("mdlGreaterWisp", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MaskBase",
                    localPos = new Vector3(0F, -0.25F, 0.65F),
                    localAngles = new Vector3(30F, 0F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Gup
            val.Add("mdlGup", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0.69F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //HAN-D
            val.Add("mdlHAND", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Hat",
                    localPos = new Vector3(0F, 0.6F, 0.3F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(2F, 2F, 2F)
                }
            });

            //Halcyonite
            val.Add("mdlHalcyonite", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "SwordPoint",
                    localPos = new Vector3(0F, 0.25F, -4.75F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)
                }
            });

            //Transport Drone
            val.Add("mdlHaulerDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, -0.25F, 0F),
                    localAngles = new Vector3(270F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Heat Vent
            val.Add("mdlHeaterPod", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HealthBarOrigin",
                    localPos = new Vector3(0F, 0F, -0.05F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Heat Vent
            val.Add("mdlHeaterPodNoRespawn", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HealthBarOrigin",
                    localPos = new Vector3(0F, 0F, 3F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Heretic
            val.Add("mdlHeretic", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0.35F, 0.42F, 0F),
                    localAngles = new Vector3(45F, 90F, 90F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Hermit Crab
            val.Add("mdlHermitCrab", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, -0.3F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.7F, 0.7F, 0.7F)
                }
            });

            //Huntress
            val.Add("mdlHuntress", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.088F, 0.191F, -0.198F),
                    localAngles = new Vector3(7.943826F, 331.0334F, 171.5755F),
                    localScale = new Vector3(0.35F, 0.35F, 0.35F)
                }
            });

            //Imp
            val.Add("mdlImp", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Neck",
                    localPos = new Vector3(0F, 0.13F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)
                }
            });

            //Imp Overlord
            val.Add("mdlImpBoss", (ItemDisplayRule[])(object)new ItemDisplayRule[5]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.87F, 1.07F, 0.9F),
                    localAngles = new Vector3(337F, 32F, 355F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(-0.93F, 1.12F, 0.8F),
                    localAngles = new Vector3(340F, 340F, 15F),
                    localScale = new Vector3(0.65F, 0.65F, 0.65F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(-1F, -0.7F, 1.25F),
                    localAngles = new Vector3(350F, 327F, 20F),
                    localScale = new Vector3(0.8F, 0.8F, 0.8F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(1.04F, -0.7F, 1.33F),
                    localAngles = new Vector3(359F, 31F, 357F),
                    localScale = new Vector3(0.6F, 0.6F, 0.6F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.62F, -1.6F, 1.56F),
                    localAngles = new Vector3(9F, 4F, 357F),
                    localScale = new Vector3(0.25F, 0.25F, 0.25F)
                }
            });

            //Solus Transporter (DOTHIS)
            val.Add("mdlIronHauler", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Jailer Drone
            val.Add("mdlJailerDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Panel2",
                    localPos = new Vector3(0.53F, 0F, 0F),
                    localAngles = new Vector3(0F, 270F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Jellyfish
            val.Add("mdlJellyfish", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0.12F, 1F, 0.25F),
                    localAngles = new Vector3(75F, 210F, 220F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Junk Cube
            /*val.Add("mdlJunkCube", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "fan",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Junk Drone
            val.Add("mdlJunkDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, -1F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Loader
            val.Add("mdlLoader", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(-0.003F, 0.113F, -0.472F),
                    localAngles = new Vector3(9.601077F, 359.9617F, 179.5275F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Lunar Chimera
            val.Add("mdlLunarExploder", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "StoneBase",
                    localPos = new Vector3(0F, 0.25F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)
                }
            });

            //Lunar Chimera
            val.Add("mdlLunarGolem", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Center",
                    localPos = new Vector3(0F, -0.95F, 1F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.8F, 0.8F, 0.8F)
                }
            });

            //Lunar Rain Shard
            /*val.Add("LunarRainModel", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Lunar Chimera
            val.Add("mdlLunarWisp", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Mask",
                    localPos = new Vector3(0F, -2F, 2F),
                    localAngles = new Vector3(40F, 0F, 0F),
                    localScale = new Vector3(1.8F, 1.8F, 1.8F)
                }
            });

            //Artificer
            val.Add("mdlMage", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0.228F, -0.421F),
                    localAngles = new Vector3(24.13002F, 0F, 180F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)
                }
            });

            //Major Construct
            val.Add("mdlMajorConstruct", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "EyeFX",
                    localPos = new Vector3(0F, 0.3F, 0.05F),
                    localAngles = new Vector3(70F, 0F, 0F),
                    localScale = new Vector3(0.3F, 0.3F, 0.3F)
                }
            });

            //Xi Construct
            val.Add("mdlMegaConstruct", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Eye",
                    localPos = new Vector3(0F, -1F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(3F, 3F, 3F)
                }
            });

            //TC-280 Prototype
            val.Add("mdlMegaDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[2]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "LeftJet",
                    localPos = new Vector3(0F, 0F, 0.2F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(2.5F, 2.5F, 2.5F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "RightJet",
                    localPos = new Vector3(0F, 0F, 0.2F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(2.5F, 2.5F, 2.5F)
                }
            });

            //Mercany
            val.Add("mdlMerc", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(-0.004F, 0.148F, -0.282F),
                    localAngles = new Vector3(9.601077F, 359.9617F, 179.5275F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                }
            });

            //Solus Distributor
            val.Add("mdlMinePod", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Screw",
                    localPos = new Vector3(0F, 0F, 0.28F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)
                }
            });

            //Mini Mushroom
            val.Add("mdlMiniMushroom", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(-0.1F, 0F, 0F),
                    localAngles = new Vector3(0F, 90F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Voidling
            val.Add("mdlVoidRaidCrab", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "FrontFootL",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Alpha Construct
            val.Add("mdlMinorConstruct", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "CapMid",
                    localPos = new Vector3(0F, 0.1F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)
                }
            });

            //Missile Drone
            val.Add("mdlMissileDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MissilePack",
                    localPos = new Vector3(0F, 0.4F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)
                }
            });

            //Void Reaver
            val.Add("mdlNullifier", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, -0.3F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(2F, 2F, 2F)
                }
            });

            //Parent
            val.Add("mdlParent", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Pelvis",
                    localPos = new Vector3(50F, 0F, 0F),
                    localAngles = new Vector3(10F, 90F, 0F),
                    localScale = new Vector3(100F, 100F, 100F)
                }
            });

            //Ancestral Pod
            /*val.Add("mdlAncestralIncubator", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Potmobile needs new child, get to fuckin'
            val.Add("mdlPotMobile", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MuzzleLeft",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Railgunner
            val.Add("mdlRailGunner", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Backpack",
                    localPos = new Vector3(-0.096F, -0.18F, -0.1F),
                    localAngles = new Vector3(0F, 180F, 0F),
                    localScale = new Vector3(0.1572773F, 0.1572773F, 0.1572773F)
                }
            });

            //Barrier Drone
            val.Add("mdlRechargeDrone", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Solus Control Unit
            val.Add("mdlRoboBallBoss", (ItemDisplayRule[])(object)new ItemDisplayRule[4]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MainEyeMuzzle",
                    localPos = new Vector3(0F, 0F, -0.15F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.4F, 0.4F, 0.4F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "EyeballMuzzle1",
                    localPos = new Vector3(0F, 0F, -0.075F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "EyeballMuzzle2",
                    localPos = new Vector3(0F, 0F, -0.075F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "EyeballMuzzle3",
                    localPos = new Vector3(0F, 0F, -0.075F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.2F, 0.2F, 0.2F)
                }
            });

            //Delighted Probe
            val.Add("mdlRoboBallMini", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Root",
                    localPos = new Vector3(0F, 0F, 1F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.25F, 0.25F, 0.25F)
                }
            });

            //Flying Rock (includes all flying rocks)
            /*val.Add("mdlSMinfiniteTowerMaulingRockLarge", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Scavenger
            val.Add("mdlScav", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 6.44F, -0.39F),
                    localAngles = new Vector3(75.00005F, 180F, 180F),
                    localScale = new Vector3(3F, 3F, 3F)
                }
            });

            //Scorch Worm
            val.Add("mdlScorchling", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MuzzleFire",
                    localPos = new Vector3(-0.5F, 0.22F, 0F),
                    localAngles = new Vector3(0F, 90F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Seeker
            val.Add("mdlSeeker", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.145F, 0.227F, -0.234F),
                    localAngles = new Vector3(354.0816F, 162.7547F, 46.18985F),
                    localScale = new Vector3(0.251912F, 0.251912F, 0.251912F)
                }
            });

            //Newt
            val.Add("mdlNewtShopkeeper", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "StompMuzzle",
                    localPos = new Vector3(-0.03F, -0.03F, -0.1F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.1F, 0.1F, 0.1F)
                }
            });

            //Solus Amalgamator
            val.Add("mdlSolusAmalgamator", (ItemDisplayRule[])(object)new ItemDisplayRule[4]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "FlamethrowerMuzzle",
                    localPos = new Vector3(0F, 0F, 0.25F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "BeamMuzzle",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(2F, 2F, 2F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MissilePod1",
                    localPos = new Vector3(0F, 0F, 1.25F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MissilePod2",
                    localPos = new Vector3(0F, 0F, 1.25F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Severed Scorcher
            val.Add("mdlFlamethrowerCannon", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "FlamethrowerMuzzle",
                    localPos = new Vector3(0F, 0F, 0.25F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Severed Breaker
            val.Add("mdlMissilePod", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Center",
                    localPos = new Vector3(0F, 0F, 1.25F),
                    localAngles = new Vector3(0F, 0F, 45F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Severed Probe
            val.Add("mdlThruster", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Center",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(3.5F, 3.5F, 3.5F)
                }
            });

            //SPEX
            val.Add("mdlSolusVendor", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HealthBarOrigin",
                    localPos = new Vector3(0F, -16F, -1.5F),
                    localAngles = new Vector3(90F, 19F, 0F),
                    localScale = new Vector3(2F, 2F, 2F)
                }
            });

            //Solus Wing
            val.Add("mdlSolusWing", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "MainEyeMuzzle",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(3F, 3F, 3F)
                }
            });

            //Squid Turret
            val.Add("mdlSquidTurret", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, 0.75F, 0.35F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Sulfur Pod
            /*val.Add("mdlSulfurPod", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Solus Scorcher
            val.Add("mdTankerUnit", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Body",
                    localPos = new Vector3(0F, 0.2F, -0.6F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.9F, 0.9F, 0.9F)
                }
            });

            //Stone Titan
            val.Add("mdlTitan", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "RightFist",
                    localPos = new Vector3(-0.2F, -0.8F, -1.5F),
                    localAngles = new Vector3(358F, 0F, 0F),
                    localScale = new Vector3(3.5F, 3.5F, 3.5F)
                }
            });

            //MUL-T
            val.Add("mdlToolbot", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.01F, 2.02F, -2.94F),
                    localAngles = new Vector3(12.39554F, 359.299F, 179.187F),
                    localScale = new Vector3(3F, 3F, 3F)
                }
            });

            //REX
            val.Add("mdlTreebot", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "FlowerBase",
                    localPos = new Vector3(0.036F, 0.791F, -0.027F),
                    localAngles = new Vector3(89.98022F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Gunner Turret
            val.Add("mdlTurret1", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "HeadCenter",
                    localPos = new Vector3(0F, 0F, 0.04F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(5F, 5F, 5F)
                }
            });

            //Malachite Urchin
            val.Add("mdlUrchinTurret", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Muzzle",
                    localPos = new Vector3(0F, 0F, -1F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(2F, 2F, 2F)
                }
            });

            //Wandering Vagrant
            val.Add("mdlVagrant", (ItemDisplayRule[])(object)new ItemDisplayRule[3]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Hull",
                    localPos = new Vector3(0.78F, 1.32F, 0.46F),
                    localAngles = new Vector3(315F, 57F, 0F),
                    localScale = new Vector3(0.65F, 0.65F, 0.65F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Hull",
                    localPos = new Vector3(0F, 1.35F, -0.8F),
                    localAngles = new Vector3(315F, 178F, 0F),
                    localScale = new Vector3(0.65F, 0.65F, 0.65F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Hull",
                    localPos = new Vector3(-0.72F, 1.35F, 0.4F),
                    localAngles = new Vector3(315F, 300F, 0F),
                    localScale = new Vector3(0.65F, 0.65F, 0.65F)
                }
            });

            //Blind Vermin
            val.Add("mdlVermin", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Spine2",
                    localPos = new Vector3(0F, 0.15F, -0.6F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Void Barnacle
            val.Add("mdlVoidBarnacle", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0.23F, 0F, 0F),
                    localAngles = new Vector3(0F, 90F, 0F),
                    localScale = new Vector3(0.8F, 0.8F, 0.8F)
                }
            });

            //Void Infestor needs children, get to fuckin'
            val.Add("mdlVoidInfestor", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });

            //Void Jailer
            val.Add("mdlVoidJailer", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "ClawMuzzle",
                    localPos = new Vector3(0F, 0F, -0.25F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.65F, 0.65F, 0.65F)
                }
            });

            //Void Devastator
            val.Add("mdlVoidMegaCrab", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "BodyBase",
                    localPos = new Vector3(0F, 6F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(10F, 10F, 10F)
                }
            });

            //Voidling
            val.Add("mockModel", (ItemDisplayRule[])(object)new ItemDisplayRule[3]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Toe",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.95F, 0.95F, 0.95F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Foot",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.95F, 0.95F, 0.95F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Calf",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(90F, 0F, 0F),
                    localScale = new Vector3(0.95F, 0.95F, 0.95F)
                }
            });

            //Void Fiend
            val.Add("mdlVoidSurvivor", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0.004229452F, -0.001436666F, -0.2302293F),
                    localAngles = new Vector3(2.552165F, 183.8695F, 0.277749F),
                    localScale = new Vector3(0.3350281F, 0.3350281F, 0.3350281F)
                }
            });

            //Alloy Vulture
            val.Add("mdlVulture", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, -1F, 0.2F),
                    localAngles = new Vector3(85F, 180F, 180F),
                    localScale = new Vector3(3F, 3F, 3F)
                }
            });

            //Eggs
            /*val.Add("mdlVultureEgg", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Chest",
                    localPos = new Vector3(0F, 0F, 0F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                }
            });*/

            //Alloy Hunter
            val.Add("mdlVultureHunter", (ItemDisplayRule[])(object)new ItemDisplayRule[3]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(-0.4F, 0.4F, 0F),
                    localAngles = new Vector3(45F, 90F, 0F),
                    localScale = new Vector3(1F, 1F, 1F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "ShoulderMuzzleL",
                    localPos = new Vector3(0F, 0F, -0.1F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)
                },
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "ShoulderMuzzleR",
                    localPos = new Vector3(0F, 0F, -0.1F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(1.5F, 1.5F, 1.5F)
                }
            });

            //Lesser Wisp
            val.Add("mdlWisp1Mouth", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Head",
                    localPos = new Vector3(0F, 0.45F, 0.24F),
                    localAngles = new Vector3(285F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            //Solus Prospector
            val.Add("mdlWorkerUnit", (ItemDisplayRule[])(object)new ItemDisplayRule[1]
            {
                new ItemDisplayRule
                {
                    ruleType = (ItemDisplayRuleType)0,
                    followerPrefabAddress = new UnityEngine.AddressableAssets.AssetReferenceGameObject(RoR2_Base_QuestVolatileBattery.DisplayBatteryArray_prefab),
                    childName = "Body",
                    localPos = new Vector3(0F, 0F, 0.4F),
                    localAngles = new Vector3(0F, 0F, 0F),
                    localScale = new Vector3(0.5F, 0.5F, 0.5F)
                }
            });

            return val;
        }

        /*public static void AddChildren()
        {
            //get the reliquary prefab, model, and childlocator
            GameObject ReliquaryPrefab = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/ArtifactShell/ArtifactShellBody.prefab").WaitForCompletion();
            GameObject ReliquaryModel = ReliquaryPrefab.GetComponent<ModelLocator>().modelTransform.gameObject;
            //CharacterModel ReliquaryCM = ReliquaryModel.GetComponent<CharacterModel>();
            //ReliquaryCM.itemDisplayRuleSet = new ScriptableObject<ItemDisplayRuleSet>();
            ChildLocator ReliquaryChildren = ReliquaryModel.GetComponent<ChildLocator>();

            ReliquaryChildren.AddChild("Sphere", ReliquaryModel.transform.Find("Sphere").transform);
        }*/

        //Needs ItemDisplayRuleSet: Voidling, Reliquary
        //Needs Children: healing core, potmobile, void infestor
        //Needs childlocators: lunar rain, lunar rain shard, ancestral pod, general mesh, ??? mithrix
    }
}
