namespace CSharpExtensionMethods.Tests
{
    [TestClass]
    public class DictionaryExtensionTests
    {
        [TestMethod]
        public void HasKeyTest_Accuracy()
        {
            var dic = new Dictionary<string, int> { { "key1", 1 }, { "key2", 2 } };
            Assert.IsTrue(dic.HasKey("key1"));
            Assert.IsFalse(dic.HasKey("key3"));
        }

        [TestMethod]
        public void HasKey_ReturnFalseWhenDicIsNull()
        {
            Dictionary<string, int> dic = null;
            Assert.IsFalse(dic.HasKey("key1"));
        }

        [TestMethod]
        public void HasKey_ReturnFalseWhenKeyIsNull()
        {
            var dic = new Dictionary<string, int> { { "key1", 1 }, { "key2", 2 } };
            Assert.IsFalse(dic.HasKey(null));
        }
    }
}