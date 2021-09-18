using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class PlayerInputController : MonoBehaviour, IPointerDownHandler
    {
        private Camera _camera;
        
        #region Public

        public void OnPointerDown(PointerEventData eventData)
        {
            if (Physics.Raycast(_camera.ScreenPointToRay(eventData.position), out RaycastHit hit) &&
                hit.transform.TryGetComponent(out TileController tile))
            {
                tile.Process();
            }
        }

        #endregion

        #region Unity

        private void Awake()
        {
            _camera = Camera.current;
        }

        #endregion

        #region Action

        #endregion

        #region Private

        #endregion
    }
}