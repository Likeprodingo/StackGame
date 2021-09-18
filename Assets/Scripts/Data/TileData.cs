using System;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class TileData : PoolObjectData
    {
        [field: SerializeField] public TileTypeEnum Type { get; private set; } 
      
    }
}