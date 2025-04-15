using System.Collections;

namespace CSharpExtensionMethods.Tests
{
    [TestClass]
    public class IListExtensionsTests
    {
        [TestMethod]
        public void FirstOrDefaultTest_ReturnDefaultWhenListIsNull()
        {
            IList list = null;
            int result = list.FirstOrDefault<int>(i => i == 1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FirstOrDefaultTest_ReturnDefaultValueWhenListIsEmpty()
        {
            IList list = new List<int>();
            int result = list.FirstOrDefault<int>(i => i == 1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void FirstOrDefaultTest_ReturnFirstElementWhenListIsNotEmpty()
        {
            IList list = new List<int> { 1, 2, 3 };
            int result = list.FirstOrDefault<int>(i => i == 2);
            Assert.AreEqual(2, result);
        }
    }
}