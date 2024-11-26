using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
namespace Tyuiu.SeledkovNP.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {

            
            string outputPath = "OutPutDataFileTask7V28.txt";                  // Определяем имя выходного файла

            string inputData = File.ReadAllText(path);                       // Читаем все строки из входного файла

            string cleanedData = Regex.Replace(inputData, @"s{2,}", " ");  // Используем регулярное выражение для замены пробелов

            File.WriteAllText(outputPath, cleanedData);                  // Сохраняем результат в выходной файл


            return outputPath;

        }
    }
}
