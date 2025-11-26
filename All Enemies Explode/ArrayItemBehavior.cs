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

            this.attachment.gameObject.AddComponent<CustomItemDisplay>();

            this.attachment.gameObject.GetComponent<CustomItemDisplay>().characterModel = this.gameObject.GetComponent<ModelLocator>().modelTransform.GetComponent<CharacterModel>();
        }

        private void OnDestroy()
        {
            //if there the attachment still exists and the death option isn't instant/delay explosion, delete the attachments gameobject
            if (this.attachment && Main.WhatOnDeath.Value != Main.DeathOptions.ExplodeInstant && Main.WhatOnDeath.Value != Main.DeathOptions.ExplodeDelay)
            {
                global::UnityEngine.Object.Destroy(this.attachment.gameObject);
                this.attachment = null;
            }
        }

        //the attachment for the fuel array item prefab
        private CustomNetworkBehavior attachment;
    }
}
