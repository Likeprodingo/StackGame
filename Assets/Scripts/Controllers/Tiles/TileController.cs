using System;
using Pool;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class TileController : PooledObject, IUsesProcessable
    {
        public event Action<TileController> Depleted = delegate {  };
        
        [SerializeField] protected Collider _collider;
        
        #region Public

        public virtual void Activate()
        {
            _collider.enabled = true;
        }

        public virtual void Deactivate()
        {
            _collider.enabled = false;
        }
        
        public override void SpawnFromPool()
        {
            base.SpawnFromPool();
            Deactivate();
        }
        
        public abstract void Process();
        
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