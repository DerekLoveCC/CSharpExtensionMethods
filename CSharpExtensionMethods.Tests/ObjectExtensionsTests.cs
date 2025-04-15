using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpExtensionMethods;

namespace CSharpExtensionMethods.Tests
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        [DataRow("123", (short)123)]
        [DataRow(null, null)]
        [DataRow("invalid", null)]
        public void ToNullableShort_ShouldConvertCorrectly(object input, short? expected)
        {
            var result = input.ToNullableShort();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("123", 123)]
        [DataRow(null, null)]
        [DataRow("invalid", null)]
        public void ToNullableInt_ShouldConvertCorrectly(object input, int? expected)
        {
            var result = input.ToNullableInt();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("123456789", 123456789L)]
        [DataRow(null, null)]
        [DataRow("invalid", null)]
        public void ToNullableLong_ShouldConvertCorrectly(object input, long? expected)
        {
            var result = input.ToNullableLong();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("123.45", 123.45f)]
        [DataRow(null, null)]
        [DataRow("invalid", null)]
        public void ToNullableFloat_ShouldConvertCorrectly(object input, float? expected)
        {
            var result = input.ToNullableFloat();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("123.45", 123.45)]
        [DataRow(null, null)]
        [DataRow("invalid", null)]
        public void ToNullableDouble_ShouldConvertCorrectly(object input, double? expected)
        {
            var result = input.ToNullableDouble();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("true", true)]
        [DataRow("false", false)]
        [DataRow(null, null)]
        [DataRow("invalid", null)]
        public void ToNullabelBool_ShouldConvertCorrectly(object input, bool? expected)
        {
            var result = input.ToNullabelBool();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("Monday", DayOfWeek.Monday)]
        [DataRow(null, null)]
        [DataRow("invalid", null)]
        public void ToNullableEnum_ShouldConvertCorrectly(object input, DayOfWeek? expected)
        {
            var result = input.ToNullableEnum<DayOfWeek>();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void In_ShouldReturnTrueIfObjectIsInArray()
        {
            var obj = 5;
            var array = new[] { 1, 2, 3, 5 };
            var result = obj.In(array);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void In_ShouldReturnFalseIfObjectIsNotInArray()
        {
            var obj = 10;
            var array = new[] { 1, 2, 3, 5 };
            var result = obj.In(array);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void In_ShouldReturnFalseIfArrayIsNull()
        {
            var obj = 5;
            int[] array = null;
            var result = obj.In(array);
            Assert.IsFalse(result);
        }
    }
}
