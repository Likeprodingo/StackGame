using System;
using System.Collections.Generic;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace
{
    public class ResourceCollectorManager : MonoBehaviour
    {
        [SerializeField] private InventoryManager _inventoryManager;
        
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
            if (resource.Take(1, out ResourceData newResource))
            {
                _inventoryManager.Add(newResource);
            }
        }
        
        #endregion

        #region Private

        #endregion
    }
}