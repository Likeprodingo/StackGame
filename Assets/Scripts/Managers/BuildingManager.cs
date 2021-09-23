using System;
using System.Collections.Generic;
using Controllers;
using Controllers.Tiles.GroundTiles;
using DefaultNamespace.Enums;
using DefaultNamespace.SO;
using UI;
using UI.BuildingSystemUI;
using UnityEngine;

namespace DefaultNamespace
{
    public class BuildingManager : MonoBehaviour
    {
        public static event Action<BuildingDataSO> Built = delegate{  };
        public static event Action<List<BuildingDataSO>> BuildingStarted = delegate { };

        [SerializeField] private PreviewBuildingController _previewBuildingController;
        [SerializeField] private InventoryManager _inventoryManager;

        private GroundTileController _selectedGround;
        private BuildingDataSO _selectedBuilding;

        #region Public

        #endregion

        #region Unity

        private void OnEnable()
        {
            GroundTileController.BuildGroundSelected += GroundTileControllerOnBuildGroundSelected;
            PlayerInputController.Broke += PlayerInputControllerOnBroke;
            PlayerInputController.Holded += PlayerInputControllerOnHolded;
            BuildingSelectorController.Selected += BuildingSelectorControllerOnSelected;
        }

        private void OnDisable()
        {
            GroundTileController.BuildGroundSelected -= GroundTileControllerOnBuildGroundSelected;
            PlayerInputController.Broke -= PlayerInputControllerOnBroke;
            PlayerInputController.Holded -= PlayerInputControllerOnHolded;
            BuildingSelectorController.Selected -= BuildingSelectorControllerOnSelected;
        }

        #endregion

        #region Action

        private void BuildingSelectorControllerOnSelected(BuildingDataSO obj)
        {
            _selectedBuilding = obj;
            if (!ReferenceEquals(_selectedBuilding, null))
            {
                _previewBuildingController.Preview( _selectedGround, _selectedBuilding);
            }
        }

        private void GroundTileControllerOnBuildGroundSelected(GroundTileController obj)
        {
            _selectedGround = obj;
        }

        private void PlayerInputControllerOnHolded()
        {
            if (!ReferenceEquals(_selectedGround, null))
            {
                List<BuildingDataSO> availableBuildings = new List<BuildingDataSO>();
                var buildingDataSoList = AssetManager.Instance.BuildingDataSoList;
                for (int i = 0; i < buildingDataSoList.Count; i++)
                {
                    if (buildingDataSoList[i].RequiredGroundType == _selectedGround.GroundType)
                    {
                        availableBuildings.Add(buildingDataSoList[i]);
                    }
                }
                BuildingStarted(availableBuildings);
            }
        }

        private void PlayerInputControllerOnBroke()
        {
            if (!ReferenceEquals(_selectedBuilding, null))
            {
                if (_inventoryManager.TryPay(_selectedBuilding.Cost))
                {
                    _selectedGround.Build(_selectedBuilding);
                    Built(_selectedBuilding);
                }
                _selectedGround = null;
                _selectedBuilding = null;
                _previewBuildingController.Clear();
            }
        }

        #endregion

        #region Private

        #endregion
    }
}