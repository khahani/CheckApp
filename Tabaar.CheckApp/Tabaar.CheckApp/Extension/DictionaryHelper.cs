using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tabaar.CheckApp.Extension
{
    public static class DictionaryHelper
    {
        public static void AddRange<TKey, TValue>(this Dictionary<TKey,TValue> instance, object[,] collection)
        {
            for (int i = 0; i < collection.Length / 2; i++)
            {
                instance.Add((TKey)collection[i, 0], (TValue)collection[i, 1]);
            }
        }
    }
}
