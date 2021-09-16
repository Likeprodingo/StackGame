using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Enums;
using UnityEngine;

public class StackController : MonoBehaviour
{
    [SerializeField] private GroundController _groundController;
    private readonly Stack<TileController> _tileControllers = new Stack<TileController>();

    #region Public

    public void InitStack(List<TileTypeEnum> tileTypes)
    {
        
    }

    #endregion
    
    #region Unity

    private void Awake()
    {
        _tileControllers.Push(_groundController);
    }

    #endregion
    
}
