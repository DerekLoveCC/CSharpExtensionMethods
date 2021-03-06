﻿using CSharpExtensionMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpExtensionMethods.UnitTests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void SplitToWords_Accuracy()
        {
            var targetWords = new[] { "This", "is", "a", "Apple", "for", "Derek" };
            var words = new[] { "This", "is", "aApple", "forDerek" };
            var testStr = string.Join(" ", words);

            var result = testStr.SplitToWords();

            Assert.AreEqual(targetWords.Length, result.Count);

            for (int i = 0; i < targetWords.Length; i++)
            {
                Assert.AreEqual(targetWords[i], result[i]);
            }
        }

        [TestMethod]
        public void SplitToWords_ReturnEmptyListWhenPassNullString()
        {
            string str = null;
            var result = str.SplitToWords();
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void EqualsIgnoreCase_ReturnTrueWhenBothAreNull()
        {
            string str = null;
            Assert.IsTrue(str.EqualsIgnoreCase(null));
        }

        [TestMethod]
        public void EqualsIgnoreCase_ReturnFalseWhenStringIsNull()
        {
            string str = null;
            Assert.IsFalse(str.EqualsIgnoreCase("OtherStr"));
        }

        [TestMethod]
        public void EqualsIgnoreCase_ReturnTrueWhenStrEqualsWithDiffCase()
        {
            string str = "A String Test";
            Assert.IsTrue(str.EqualsIgnoreCase("A STRING TEST"));
        }
    }
}