using RoR2;
using UnityEngine;
using UnityEngine.Networking;

namespace AllEnemiesExplode
{
    public class CustomNetworkBehavior : NetworkBehaviour
    {
        private Transform targetTransform;//the transform of the target

        private HealthComponent targetHealthComponent;//the health component of the target

        public float maxHealth;//the max health of the target

        [SyncVar(hook = nameof(OnSyncTarget))]
        private GameObject target;//the targetted gameobject to follow

        //when target is updated, set all clients targets to the same thing
        private void OnSyncTarget(GameObject newTarget)
        {
            target = newTarget;
            targetTransform = target ? target.transform : null;
            targetHealthComponent = target ? target.GetComponent<HealthComponent>() : null;
            attachedBody = target ? target.GetComponent<CharacterBody>() : null;
        }

        public GameObject attachedBodyObject => target;//the attached body object will always be the target

        public CharacterBody attachedBody;//the attached character body

        //creates a gameobject that will have itself synced to the target
        [Server]
        public void AttachAndSpawn(GameObject targetObject)
        {
            OnSyncTarget(targetObject);
            NetworkServer.Spawn(base.gameObject);
        }

        private void FixedUpdate()
        {
            //every update, if the target exists, go to it
            if (targetTransform)
            {
                transform.position = targetTransform.position;
                transform.rotation = targetTransform.rotation;
            }
            //if it has a health component, set 
            if (targetHealthComponent)
            {
                maxHealth = targetHealthComponent.fullCombinedHealth;
            }
        }

        //make the client sync itself with the server
        public override void OnStartClient()
        {
            base.OnStartClient();
            OnSyncTarget(target);
        }
    }
}
