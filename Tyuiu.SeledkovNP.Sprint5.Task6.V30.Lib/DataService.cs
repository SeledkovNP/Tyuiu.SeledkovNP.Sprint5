﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Globalization;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
namespace Tyuiu.SeledkovNP.Sprint5.Task6.V30.Lib
{
    public class DataService : ISprint5Task6V30
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;


            using (StreamReader reader = new StreamReader(path))
            {

                string line;
                
                 while ((line = reader.ReadLine()) != null)
                 {
                    
                   // for (int i = 0; i < line.Length; i++)     щитаем слова на каждую букву
                    {
                        string[] words = line.Split(new char[] { ' '});  //Разделает по словам
                        foreach (var word in words)
                        {
                            if (word.Length == 8)
                            {
                                count++;
                            }
                        }
                    }
                     
                     
                 }
            } 
            return count;


        }
    }
}
