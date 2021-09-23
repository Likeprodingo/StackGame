using System;
using Controllers.Buildings;
using DefaultNamespace;
using DefaultNamespace.Enums;
using DefaultNamespace.SO;
using Pool;
using UnityEngine;

namespace Controllers.Tiles.GroundTiles
{
    public class GroundTileController : BaseTileController 
    {
        public static event Action<GroundTileController> BuildGroundSelected = delegate {  };

        [SerializeField] private GroundType _groundType;
        [SerializeField] private Transform _spawnParent;
        
        private BaseBuildingController _placedBuilding;

        public GroundType GroundType => _groundType;

        #region Public

        public void Build(BuildingDataSO buildingDataSo)
        {
            _placedBuilding = ObjectPool.Instance.Get<BaseBuildingController>(buildingDataSo.Prefab, _spawnParent);
        }
        
        public override void Process()
        {
            if (!ReferenceEquals(_placedBuilding, null))
            {
                _placedBuilding.Process();
            }
            else
            {
                BuildGroundSelected(this);
            }
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