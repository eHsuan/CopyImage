using CopyImage;

namespace CopyImage.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = MainProcess.GenerateFileName(@"File1", "File2");
            string expected = "File1" + "File2";
            Assert.AreEqual(expected, path);
        }
    }
}