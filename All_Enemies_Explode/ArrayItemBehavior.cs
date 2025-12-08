using RoR2;

namespace AllEnemiesExplode
{
    public class FuelArrayItemBehavior : CharacterBody.ItemBehavior
    {
        private void Start()
        {
            //when a fuel array item behavior is made, create a fuel array item prefab and set attachment to its custom network behavior
            this.attachment = Instantiate(Main.FuelArrayItemPrefab).GetComponent<CustomNetworkBehavior>();
            //then use attach and spawn to make a gameobject that follows the attached gameobject (not parented)
            this.attachment.AttachAndSpawn(this.body.gameObject);

            //attach a custom item display to attachment
            this.attachment.gameObject.AddComponent<CustomItemDisplay>();
            //then set the pass the proper character model into the custom item display component
            this.attachment.gameObject.GetComponent<CustomItemDisplay>().characterModel = this.gameObject.GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>();
        }

        private void OnDestroy()
        {
            //if the array item behavior is being destroyed, check if the gameobject is still there
            if (this.gameObject)
            {
                //then check for a health component
                if (this.gameObject.GetComponent<HealthComponent>())
                {
                    //then check to see if its alive
                    if (this.gameObject.GetComponent<HealthComponent>().alive)
                    {
                        //then check to see if the attachment still exists
                        if (this.attachment)
                        {
                            //if it does, destroy the attachment
                            Destroy(this.attachment.gameObject);
                        }
                    }
                }
            }
            //if there the attachment still exists and the death option isn't instant/delay explosion, delete the attachments gameobject
            if (this.attachment && Main.WhatOnDeath.Value != Main.DeathOptions.ExplodeInstant && Main.WhatOnDeath.Value != Main.DeathOptions.ExplodeDelay)
            {
                global::UnityEngine.Object.Destroy(this.attachment.gameObject);
                this.attachment = null;
            }
        }

        //the attachment for the fuel array item prefab
        public CustomNetworkBehavior attachment;
    }
}
