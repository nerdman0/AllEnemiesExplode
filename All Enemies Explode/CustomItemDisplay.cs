using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace AllEnemiesExplode
{
    public class CustomItemDisplay : MonoBehaviour
    {
        private bool developerMode = false;

        public CharacterModel characterModel;

        private GameObject display = Main.FuelArrayModel;

        private List<GameObject> itemDisplays;

        public List<GameObject> customDisplays = new List<GameObject>();

        public void Start()
        {
            itemDisplays = characterModel.GetItemDisplayObjects(AllEnemiesExplode.Main.FuelArrayItem.itemIndex);
            if (itemDisplays.Count > 0)
            {
                for (int i = 0; i < itemDisplays.Count; i++)
                {
                    var tempItem = Instantiate(display);
                    tempItem.transform.localScale = itemDisplays[i].transform.lossyScale;
                    customDisplays.Add(tempItem);
                    if (!developerMode)
                    {
                        itemDisplays[i].transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
            }
        }

        private void FixedUpdate()
        {
            if (characterModel)
            {
                if(customDisplays.Count > 0 && itemDisplays.Count > 0)
                {
                    for(int i = 0; i < itemDisplays.Count; i++)
                    {
                        if(Main.EnableItemDisplay.Value) { customDisplays[i].SetActive(true); } else { customDisplays[i].SetActive(false); }
                        customDisplays[i].transform.position = itemDisplays[i].transform.position;
                        customDisplays[i].transform.rotation = itemDisplays[i].transform.rotation;
                    }
                }
            }
        }

        private void OnDestroy()
        {
            if(customDisplays.Count > 0)
            {
                for (int i = 0; i < customDisplays.Count; i++)
                {
                    Destroy(customDisplays[i]);
                }
            }
        }
    }
}
