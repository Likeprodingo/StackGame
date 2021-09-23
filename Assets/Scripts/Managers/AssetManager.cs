using System.Collections.Generic;
using DefaultNamespace.Enums;
using DefaultNamespace.SO;
using UnityEngine;
using Util;

namespace DefaultNamespace
{
    public class AssetManager : Singleton<AssetManager>
    {
        [field: SerializeField]
        public List<DepletingTileData> TileDataList { get; private set; } = new List<DepletingTileData>();

        [field: SerializeField]
        public List<BuildingDataSO> BuildingDataSoList { get; private set; } = new List<BuildingDataSO>();

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