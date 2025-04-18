﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpExtensionMethods
{
    public static class IListExtensions
    {
        public static T FirstOrDefault<T>(this IList list)
        {
            return FirstOrDefault<T>(list, _ => true);
        }

        public static T FirstOrDefault<T>(this IList list, Predicate<T> predicate)
        {
            if (list == null)
            {
                return default;
            }

            foreach (var listItem in list)
            {
                if (listItem is T li && predicate(li))
                {
                    return li;
                }
            }

            return default;
        }

        public static void AddRange<T>(this IList list, IEnumerable<T> elementsToAdd)
        {
            foreach (var ele in elementsToAdd)
            {
                list.Add(ele);
            }
        }
    }
}