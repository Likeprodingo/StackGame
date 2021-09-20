using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class ResourceCollectorManager : MonoBehaviour
    {

        public static event Action<ResourceData> ResourceCollected = delegate {  };

        #region Public

        #endregion

        #region Unity

        private void OnEnable()
        {
            ResourceTileController.ResourcePicked += ResourceTileControllerOnResourcePicked;
        }

        private void OnDisable()
        {
            ResourceTileController.ResourcePicked -= ResourceTileControllerOnResourcePicked;
        }
        
        #endregion

        #region Action
        
        private void ResourceTileControllerOnResourcePicked(ResourceData resource)
        {
            ResourceData collectedResource = resource.Pick(1);
            ResourceCollected(collectedResource);
        }
        
        #endregion

        #region Private

        #endregion
    }
}