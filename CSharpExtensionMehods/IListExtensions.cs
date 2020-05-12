using System;
using System.Collections;

namespace CSharpExtensionMehods
{
    public static class IListExtensions
    {
        public static T FirstOrDefault<T>(this IList list, Predicate<T> predicate)
        {
            foreach (var listItem in list)
            {
                if (listItem is T li && predicate(li))
                {
                    return li;
                }
            }

            return default(T);
        }
    }
}