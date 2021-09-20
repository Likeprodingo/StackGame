using System;
using DefaultNamespace.Enums;
using UnityEngine;

namespace DefaultNamespace
{
    [Serializable]
    public class ResourceData
    {
        [field: SerializeField] public ResourceType Type { get; private set; } 
        [field: SerializeField] public int Count { get; private set; }

        public ResourceData(ResourceType type, int count)
        {
            Type = type;
            Count = count;
        }

        public ResourceData Pick(int count)
        {
            Count -= count;
            return new ResourceData(Type, count);
        }
    }
}