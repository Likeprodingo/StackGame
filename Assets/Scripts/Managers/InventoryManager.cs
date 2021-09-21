using System;
using System.Collections.Generic;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace
{
    public class InventoryManager : MonoBehaviour
    {
        
        private readonly Dictionary<ResourceType, ResourceData> _resources = new Dictionary<ResourceType, ResourceData>();
        
        #region Public

        public void Add(ResourceData resource)
        {
            if (_resources.TryGetValue(resource.Type, out ResourceData savedResource))
            {
                savedResource.Add(resource);
            }
            else
            {
                _resources.Add(resource.Type, resource);   
            }
        }

        public bool TryPay(ResourceData requiredResource)
        {
            if (_resources.TryGetValue(requiredResource.Type, out ResourceData savedResource) && savedResource.Take(requiredResource.Count))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Unity
        
        #endregion

        #region Action

        #endregion

        #region Private

        #endregion
    }
}