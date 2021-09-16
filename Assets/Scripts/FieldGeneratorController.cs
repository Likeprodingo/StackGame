using System;
using UnityEngine;
using UnityEngine.Tilemaps;
using Tile = UnityEngine.WSA.Tile;

namespace DefaultNamespace
{
    public class FieldGeneratorController : MonoBehaviour
    {
        
        [SerializeField] private Tilemap _tilemap;
        [SerializeField] private float _stepSize;

        private Vector3Int _middleTile;

        #region Public

        private void Awake()
        {
            _middleTile = _tilemap.WorldToCell(Vector3.zero);
            _stepSize = _tilemap.layoutGrid.cellSize.x;
            Debug.Log(_tilemap.size);
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