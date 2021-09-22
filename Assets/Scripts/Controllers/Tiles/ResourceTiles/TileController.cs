using System;
using Pool;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class TileController : BaseTileController
    {
        public event Action<TileController> Depleted = delegate {  };
        
        #region Public

        public override void Activate()
        {
            _collider.enabled = true;
        }

        public override void Deactivate()
        {
            _collider.enabled = false;
        }
        
        public override void SpawnFromPool()
        {
            base.SpawnFromPool();
            Deactivate();
        }
        
        #endregion

        #region Unity

        #endregion

        #region Action

        #endregion

        #region Protected

        private void DestroyTile()
        {
            Free();
        }

        protected void Deplete()
        {
            Depleted(this);
            DestroyTile();
        }
        
        #endregion
    }
}