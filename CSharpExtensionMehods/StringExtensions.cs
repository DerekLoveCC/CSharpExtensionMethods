﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharpExtensionMethods;

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }

    public static bool IsNullOrWhiteSpace(this string str)
    {
        return string.IsNullOrWhiteSpace(str);
    }

    public static IList<string> SplitToWords(this string str)
    {
        var result = new List<string>();
        if (string.IsNullOrWhiteSpace(str))
        {
            return result;
        }

        var matchCollection = Regex.Matches(str, @"[A-Z\s]+|[^A-Z\s]+");
        for (int i = 0; i < matchCollection.Count; i += 2)
        {
            if (string.IsNullOrWhiteSpace(matchCollection[i].Value))
            {
                if (i + 1 < matchCollection.Count)
                {
                    result.Add(matchCollection[i + 1].Value);
                }
            }
            else
            {
                if (i + 1 < matchCollection.Count)
                {
                    result.Add(matchCollection[i].Value + matchCollection[i + 1].Value);
                }
                else
                {
                    result.Add(matchCollection[i].Value);
                }
            }
        }

        return result;
    }

    public static bool EqualsIgnoreCase(this string str,
                                        string otherStr,
                                        StringComparison comparison = StringComparison.OrdinalIgnoreCase)
    {
        if (str == otherStr)
        {
            return true;
        }

        return string.Equals(str, otherStr, comparison);
    }
}