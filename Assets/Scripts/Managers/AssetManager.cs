using System.Collections.Generic;
using DefaultNamespace.Enums;
using UnityEngine;
using Util;

namespace DefaultNamespace
{
    public class AssetManager : Singleton<AssetManager>
    {
        [field: SerializeField] public List<DepletingTileData> TileDataList { get; private set; }  = new List<DepletingTileData>();

        public TileController GetTileByType(TileTypeEnum typeEnum)
        {
            for (int i = 0; i < TileDataList.Count; i++)
            {
                if (TileDataList[i].Type == typeEnum)
                {
                    return TileDataList[i].Prefab;
                }
            }

            return null;
        }
    }
}