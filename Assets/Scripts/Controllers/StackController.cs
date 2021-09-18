using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Enums;
using Pool;
using UnityEngine;
using Object = System.Object;

public class StackController : MonoBehaviour
{
    [Header("References")] [SerializeField]
    private List<TileTypeEnum> _tileTypes;

    [SerializeField] private GroundTileController _groundTileController;
    [SerializeField] private Transform _stackParent;
    [Header("Values")] [SerializeField] private float _tileDeltaPos;

    private readonly Stack<TileController> _placedTiles = new Stack<TileController>();

    private TileController _selectedTile;

    #region Public

    public void InitStack(List<TileTypeEnum> tileTypes)
    {
        ClearStack();
        for (int i = 0; i < tileTypes.Count; i++)
        {
            AddTile(tileTypes[i]);
        }

        SelectNextTile();
    }

    #endregion

    #region Unity

    private void Start()
    {
        InitStack(_tileTypes);
    }

    #endregion

    #region Private

    private void SelectNextTile()
    {
        if (_placedTiles.Count > 0)
        {
            _selectedTile = _placedTiles.Pop();
        }
        else
        {
            _selectedTile = _groundTileController;
        }
    }
    
    private void AddTile(TileTypeEnum type)
    {
        var prefab = AssetManager.Instance.GetTileByType(type);
        var tile = ObjectPool.Instance.Get<TileController>(prefab,
            new Vector3(0, _placedTiles.Count * _tileDeltaPos, 0), Quaternion.identity,
            _stackParent);
        _placedTiles.Push(tile);
    }
    
    private void ClearStack()
    {
        _placedTiles.Clear();
    }

    #endregion
}