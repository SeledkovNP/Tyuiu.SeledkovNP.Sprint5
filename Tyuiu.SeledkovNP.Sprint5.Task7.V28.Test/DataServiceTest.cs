using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.SeledkovNP.Sprint5.Task7.V28.Lib;
namespace Tyuiu.SeledkovNP.Sprint5.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Vaennet\source\repos\Tyuiu.SeledkovNP.Sprint5\Tyuiu.SeledkovNP.Sprint5.Task7.V30\bin\Debug\net8.0\OutPutFileTask7.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}