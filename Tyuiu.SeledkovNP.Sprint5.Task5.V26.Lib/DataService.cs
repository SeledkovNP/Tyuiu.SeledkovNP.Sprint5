using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
namespace Tyuiu.SeledkovNP.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {

            double positiveSum = 0;
            double negativeSum = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');

                    foreach (string number in numbers)
                    {
                        if (number.Contains(".") || number.Contains(","))
                        { 
                            if (double.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                            {
                                if (value > 0)
                                {
                                    positiveSum += value;               //  positiveSum будет   +
                                }
                                else if (value < 0)
                                {
                                    negativeSum += value;               // negativeSum будет    -
                                }
                            }
                        else
                        {
                            Console.WriteLine($"Не удалось преобразовать '{number}' в double.");
                        }
                      }
                    }
                }
               
            }


            double difference = positiveSum + Math.Abs(negativeSum);          // negativeSum отрицательный, поэтому берем abs
            return Math.Round(difference, 3);

        }

        
    }
}
