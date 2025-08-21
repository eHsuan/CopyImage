using CopyImage;

namespace CopyImage.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = MainProcess.GenerateFileName(@"D:\", "File2");
            Assert.AreEqual(@"D:\File2", path);
        }
    }
}