using System;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class PoolObjectData
    {
        [field: SerializeField] public TileController Prefab { get; private set; }
        [field: SerializeField] public int PrepareCount { get; private set; }
    }
}