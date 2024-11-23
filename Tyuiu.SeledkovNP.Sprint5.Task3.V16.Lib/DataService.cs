using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SeledkovNP.Sprint5.Task3.V16.Lib
{
    public class DataService : ISprint5Task3V16
    {
        public string SaveToFileTextData(int x)
        {

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt");

            double y = Math.Round((2 * Math.Pow(x, 2) - 1) / Math.Sqrt(Math.Pow(x, 2) - 2), 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;

        }
    }
}
