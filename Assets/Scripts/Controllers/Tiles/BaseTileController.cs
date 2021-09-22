using Pool;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class BaseTileController : PooledObject, IUserProcessable
    {
        [SerializeField] protected Collider _collider;

        public virtual void Activate()
        {
            _collider.enabled = true;
        }

        public virtual void Deactivate()
        {
            _collider.enabled = false;
        }

        public abstract void Process();
    }
}