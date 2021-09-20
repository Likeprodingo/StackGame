using System;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class DepletingTileData
    {
        [field: SerializeField] public TileTypeEnum Type { get; private set; }
        [field: SerializeField] public TileController Prefab { get; private set; }
        [field: SerializeField] public int PrepareCount { get; private set; }
    }
}