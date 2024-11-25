using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
namespace Tyuiu.SeledkovNP.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {

            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] numbers = line.Split(' ');             // Разделяем строку на части по пробелам

                    foreach (string number in numbers)
                    {
                             // Мой спаситель, который из точки сделает запетую
                        if (double.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))               // Преобразуем каждую часть в double и добавляем к результату
                        {
                            res += value;
                        }
                        else
                        {
                            
                            Console.WriteLine($"Не удалось преобразовать '{number}' в double.");           // Обработка случая, если преобразование не удалось 
                        }
                    }
                }
            }
            return Math.Round(res, 3);

        }
    }
}
