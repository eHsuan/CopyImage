using CopyImage;

namespace CopyImage.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = MainProcess.GenerateFileName(@"D:\", "File");
            Assert.AreEqual(@"D:\File", path);
        }
    }
}