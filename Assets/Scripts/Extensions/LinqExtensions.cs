using System;
using System.Collections.Generic;
using UnityEngine;

namespace Extensions
{
    public static class LinqExtensions
    {
        public static void Do<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable == null)
            {
                Debug.LogError("enumerable is null");
                return;
            }

            foreach (var item in enumerable)
            {
                action(item);
            }
        }

        public static T RandomElement<T>(this IList<T> enumerable)
        {
            return enumerable[UnityEngine.Random.Range(0, enumerable.Count)];
        }

        public static bool NonNull(this MonoBehaviour self)
        {
            return !ReferenceEquals(self, null);
        }
    }
}