using System;
using System.Collections;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class PlayerInputController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        public static event Action<Vector2> Dragged = delegate {  }; 
        public static event Action Holded = delegate {  };
        public static event Action Broke = delegate { };

        [SerializeField] private float _holdCheckDelayTime = 0.8f;
        
        private Camera _camera;
        private Coroutine _holdCheckCor;
        private WaitForSeconds _holdWaiter;
        
        #region Public

        public void OnPointerDown(PointerEventData eventData)
        {
            if (Physics.Raycast(_camera.ScreenPointToRay(eventData.position), out RaycastHit hit) &&
                hit.transform.TryGetComponent(out IUserProcessable obj))
            {
                obj.Process();
                _holdCheckCor = StartCoroutine(HoldCheckCoroutine());
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (!ReferenceEquals(_holdCheckCor, null))
            {
                StopCoroutine(_holdCheckCor);
                _holdCheckCor = null;
                Broke();
            }
        }

        #endregion

        #region Unity

        private void Awake()
        {
            _camera = Camera.main;
            _holdWaiter = new WaitForSeconds(_holdCheckDelayTime);
        }

        #endregion

        #region Action

        #endregion

        #region Private

        private IEnumerator HoldCheckCoroutine()
        {
            yield return _holdWaiter;
            Holded();
        }
        
        #endregion
    }
}