using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace AllEnemiesExplode
{
    public class CustomItemDisplay : MonoBehaviour
    {
        private bool developerMode = false;

        public CharacterModel characterModel;//the character model we are putting item displays on

        private GameObject display = Main.FuelArrayModel;//the item display model

        private List<GameObject> itemDisplays;//a list of regular item displays on the character model

        public List<GameObject> customDisplays = new List<GameObject>();//a list of custom item displays given to the model

        public void Start()
        {
            //set item displays to the attached character models item displays
            itemDisplays = characterModel.GetItemDisplayObjects(AllEnemiesExplode.Main.FuelArrayItem.itemIndex);
            //if there is any item displays, do stuff with them
            if (itemDisplays.Count > 0)
            {
                //for each item display on the character model...
                for (int i = 0; i < itemDisplays.Count; i++)
                {
                    //get the parent object for the item displays and attach the orphan component to them
                    Transform displayParent = itemDisplays[i].gameObject.transform.parent;
                    displayParent.gameObject.AddComponent<OrphanLBozo>();
                    var tempItem = Instantiate(display);//instantiate a custom display
                    tempItem.transform.localScale = itemDisplays[i].transform.lossyScale;//scale the custom so its the same size as the regular display
                    tempItem.transform.parent = displayParent;//parent the item display to the parent
                    tempItem.transform.localPosition = itemDisplays[i].transform.localPosition;//move the display to the proper position
                    tempItem.transform.localRotation = itemDisplays[i].transform.localRotation;//move the display to the proper location
                    tempItem.AddComponent<DihChoppedOff>();//add a component that indicates this is a custom display
                    customDisplays.Add(tempItem);//add the display to the custom display list
                    if (!developerMode)
                    {
                        //disable the original item displays model (unless you're in developer mode)
                        itemDisplays[i].transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
        }

        private void OnDestroy()
        {
            //upon the gameobject this is attached to being destroyed, check if there is any item displays
            if (customDisplays.Count > 0)
            {
                for (int i = 0; i < customDisplays.Count; i++)
                {
                    //for each custom display, check if they have a parent
                    if (customDisplays[i].transform.parent)
                    {
                        //then check if the parent has an orphan component
                        if (customDisplays[i].transform.parent.gameObject.GetComponent<OrphanLBozo>())
                        {
                            //if it does, destroy that component
                            Destroy(customDisplays[i].gameObject.transform.parent.gameObject.GetComponent<OrphanLBozo>());
                        }
                    }
                    //then destroy the custom display
                    Destroy(customDisplays[i]);
                }
            }
        }
    }

    public class OrphanLBozo : MonoBehaviour
    {
        private void OnDestroy()
        {
            //if an orphan component get destroyed, destroy all custom display children it has
            DihChoppedOff[] dihChopped = this.gameObject.transform.GetComponentsInChildren<DihChoppedOff>();
            foreach(DihChoppedOff dihChop in dihChopped)
            {
                dihChop.gameObject.transform.SetParent(null, true);
            }
        }
    }
}
