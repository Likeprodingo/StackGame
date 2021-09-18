using System;
using UnityEngine;

namespace Util
{
    public abstract class Singleton<T> : MonoBehaviour
        where T : Component
    {
        private static T instance = null;
        
        public static void Initialize()
        {
            instance = FindObjectOfType<T>();
        }
        public static T Instance
        {
            get
            {
                if (ReferenceEquals(instance, null))
                {
                    instance = FindObjectOfType<T>();
                }
                return instance;
            }
        }
    }
}