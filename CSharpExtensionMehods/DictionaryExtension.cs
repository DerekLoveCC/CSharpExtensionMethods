using System.Collections.Generic;

namespace CSharpExtensionMethods
{
    public static class DictionaryExtension
    {
        public static bool HasKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            if (dictionary == null)
            {
                return false;
            }

            if (key == null)
            {
                return false;
            }

            return dictionary.ContainsKey(key);
        }
    }
}