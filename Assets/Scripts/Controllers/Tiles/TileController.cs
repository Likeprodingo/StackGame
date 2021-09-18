using System;
using Pool;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class TileController : PooledObject
    {
        public event Action<TileController> DriedUp = delegate {  };

        [SerializeField] protected Collider _collider;
        
        #region Public
        
        public void Activate()
        {
            _collider.enabled = true;
        }
        
        public abstract void Process();

        #endregion

        #region Unity

        #endregion

        #region Action

        #endregion

        #region Protected

        public override void SpawnFromPool()
        {
            base.SpawnFromPool();
            _collider.enabled = false;
        }
        
        protected void DryUp()
        {
            DriedUp(this);
        }

        #endregion
    }
}