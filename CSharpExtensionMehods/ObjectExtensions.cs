using System.Linq;

namespace CSharpExtensionMehods
{
    public static class ObjectExtensions
    {
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