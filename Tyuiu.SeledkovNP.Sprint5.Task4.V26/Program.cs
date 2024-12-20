﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.SeledkovNP.Sprint5.Task4.V26.Lib;

namespace Tyuiu.SeledkovNP.Sprint5.Task4.V26

{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Селедков.Н.П | Смартб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Селедков Никита Павлович | Смартб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Выполнить указанную функция на фото                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4.txt");
           // string path = @"\Users\Vaennet\source\repos\Tyuiu.SeledkovNP.Sprint5\DataSprint5\InPutDataFileTask4V26.txt";
            //  C:\Users\Vaennet\source\repos\Tyuiu.SeledkovNP.Sprint5\Tyuiu.SeledkovNP.Sprint5.Task4.V26\bin\Debug\net8.0\OutPutFileTask1.txt
            //  C:\Users\Vaennet\source\repos\Tyuiu.SeledkovNP.Sprint5\DataSprint5\InPutDataFileTask4V26.txt

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
