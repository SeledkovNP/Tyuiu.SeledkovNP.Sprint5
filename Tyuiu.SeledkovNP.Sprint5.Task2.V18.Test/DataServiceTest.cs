using Tyuiu.SeledkovNP.Sprint5.Task2.V18.Lib;
namespace Tyuiu.SeledkovNP.Sprint5.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Vaennet\source\repos\Tyuiu.SeledkovNP.Sprint5\Tyuiu.SeledkovNP.Sprint5.Task2.V18\bin\Debug\net8.0\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}