using System;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNamespace.Enums;
using DefaultNamespace.SO;
using UnityEngine;

namespace UI.BuildingSystemUI
{
    public class BuildingSelectorController : MonoBehaviour
    {
        public static event Action<BuildingDataSO> Selected = delegate { };

        #region Public

        #endregion

        #region Unity

        private void OnEnable()
        {
            BuildingManager.BuildingStarted += BuildingManagerOnBuildingStarted;
            PlayerInputController.Broke += PlayerInputControllerOnBroke;
            PlayerInputController.Dragged += PlayerInputControllerOnDragged;
        }

        private void OnDisable()
        {
            BuildingManager.BuildingStarted -= BuildingManagerOnBuildingStarted;
            PlayerInputController.Broke -= PlayerInputControllerOnBroke;
            PlayerInputController.Dragged -= PlayerInputControllerOnDragged;
        }

        #endregion

        #region Action

        private void PlayerInputControllerOnDragged(Vector2 obj)
        {
        }

        private void PlayerInputControllerOnBroke()
        {
        }

        private void BuildingManagerOnBuildingStarted(List<BuildingDataSO> obj)
        {
            
        }

        #endregion

        #region Private

        #endregion
    }
}