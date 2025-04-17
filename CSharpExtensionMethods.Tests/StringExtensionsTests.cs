using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpExtensionMethods;


namespace CSharpExtensionMethods.Tests
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

        [TestMethod()]
        public void ContainsIgnoreCaseTest_ReturnTrueWhenContain()
        {
            string str = "A String Test";
            Assert.IsTrue(str.ContainsIgnoreCase("STRING"));
        }

        [TestMethod()]
        public void ContainsIgnoreCaseTest_ReturnFalseWhenNotContain()
        {
            string str = "A String Test";
            Assert.IsFalse(str.ContainsIgnoreCase("STRING1"));
        }

        [TestMethod()]
        public void ContainsIgnoreCaseTest_ReturnFalseWhenStrIsNull()
        {
            string str = null;
            Assert.IsFalse(str.ContainsIgnoreCase("STRING1"));
        }

        [TestMethod()]
        public void ContainsIgnoreCaseTest_ReturnFalseWhenArgIsNull()
        {
            const string str = "A String Test";
            Assert.IsFalse(str.ContainsIgnoreCase(null));
        }



        [TestMethod]
        public void StartsWithIgnoreCase_ReturnTrueWhenStartsWith()
        {
            const string str = "This a test string";
            Assert.IsTrue(str.StartsWithIgnoreCase("THIS"));
        }

        [TestMethod]
        public void StartsWithIgnoreCase_ReturnFalseWhenStrIsNull()
        {
            const string str = null;
            Assert.IsFalse(str.StartsWithIgnoreCase("OtherStr"));
        }

        [TestMethod]
        public void StartsWithIgnoreCase_ReturnFalseWhenArgIsNull()
        {
            const string str = "A String Test";
            Assert.IsFalse(str.StartsWithIgnoreCase(null));
        }


        [TestMethod]
        public void EndsWithIgnoreCase_ReturnTrueWhenEndsWith()
        {
            const string str = "This a test string";
            Assert.IsTrue(str.EndsWithIgnoreCase("STRING"));
        }

        [TestMethod]
        public void EndWithIgnoreCase_ReturnFalseWhenStrIsNull()
        {
            const string str = null;
            Assert.IsFalse(str.EndsWithIgnoreCase("OtherStr"));
        }

        [TestMethod]
        public void EndWithIgnoreCase_ReturnFalseWhenArgIsNull()
        {
            const string str = "A String Test";
            Assert.IsFalse(str.EndsWithIgnoreCase(null));
        }
    }
}