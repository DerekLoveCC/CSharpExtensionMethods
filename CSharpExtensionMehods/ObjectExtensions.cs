using System;
using System.Linq;

namespace CSharpExtensionMethods
{
    public static class ObjectExtensions
    {
        public static short? ToNullableShort(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            if (short.TryParse(obj.ToString(), out short result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static int? ToNullableInt(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            if (int.TryParse(obj.ToString(), out int result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static long? ToNullableLong(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            if (long.TryParse(obj.ToString(), out long result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static float? ToNullableFloat(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            if (float.TryParse(obj.ToString(), out float result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static double? ToNullableDouble(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            if (double.TryParse(obj.ToString(), out double result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static bool? ToNullabelBool(this object obj)
        {
            if (obj == null)
            {
                return null;
            }

            if (bool.TryParse(obj.ToString(), out bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static T? ToNullableEnum<T>(this object obj) where T : struct
        {
            if (obj == null)
            {
                return null;
            }

            if (obj is T t)
            {
                return t;
            }

            if (Enum.TryParse(obj.ToString(), out T result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static bool In<T>(this T obj, params T[] objArray)
        {
            if (objArray == null)
            {
                return false;
            }

            return objArray.Any(o => o.Equals(obj));
        }
    }
}