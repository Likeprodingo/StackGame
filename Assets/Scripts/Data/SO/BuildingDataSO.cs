using System.Collections.Generic;
using Controllers.Buildings;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace.SO
{
    [CreateAssetMenu(fileName = "BuildingData", menuName = "", order = 0)]
    public class BuildingDataSO : ScriptableObject
    {
        [field: SerializeField] public List<ResourceData> Cost { get; private set; }
        [field: SerializeField] public BaseBuildingController Prefab { get; private set; }

        [field: SerializeField] public GroundType RequiredGroundType { get; private set; }
        [field: SerializeField] public Sprite Icon { get; private set; }
    }
}