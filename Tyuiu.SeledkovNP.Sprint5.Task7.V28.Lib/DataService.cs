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
using System.Net.Http.Headers;
namespace Tyuiu.SeledkovNP.Sprint5.Task7.V28.Lib
{
    public class DataService : ISprint5Task7V28
    {
        public string LoadDataAndSave(string path)
        {


            string inputFilePath = path;
            string outputFilePath = @"C:\DataSprint5\InOutPutDataFileTask7V28.txt";

            try
            {
                // Чтение содержимого входного файла
                if (!File.Exists(inputFilePath))
                {
                    Console.WriteLine("Файл с входными данными не найден!");
                    
                }
                
                string inputData = File.ReadAllText(inputFilePath);

                // Замена последовательностей пробелов на один пробел
                string outputData = Regex.Replace(inputData, @"\s{2,}", " ");

                // Сохранение результата в выходной файл
                File.WriteAllText(outputFilePath, outputData);

                Console.WriteLine("Обработка завершена. Результат сохранён в InOutPutDataFileTask7V28.txt");

                
            }
             catch (Exception ex)
             {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
             }
            
            return "Это строка с пробелами";
        }
    }
}
