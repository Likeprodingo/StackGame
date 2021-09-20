using System;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace
{
    public class ResourceTileController : TileController
    {
        public static event Action<ResourceData> ResourcePicked = delegate {  };
            
        [SerializeField] private ResourceData _resource;

        #region Public

        #endregion

        #region Unity

        #endregion

        #region Action

        #endregion

        #region Private

        public override void Process()
        {
            ResourcePicked(_resource);
            if (_resource.Count == 0)
            {
                Deplete();
            }
        }

        #endregion
    }
}