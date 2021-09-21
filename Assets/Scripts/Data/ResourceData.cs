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

        public void Add(ResourceData data)
        {
            Count += data.Count;
        }
        
        public bool Take(int count, out ResourceData resource)
        {
            if (Count < count)
            {
                resource = null;
                return false;
            }
            Count -= count;
            resource = new ResourceData(Type, count);
            return true;
        }
        
        public bool Take(int count)
        {
            if (Count < count)
            {
                return false;
            }
            Count -= count;
            return true;
        }
    }
}