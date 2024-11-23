using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SeledkovNP.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);        // проверка создан файл или нет
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);             // удолаем файла
            }


            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(((3 * Math.Cos(x)) / (4 * x - 0.5)) + Math.Sin(x) - 5 * x - 2, 2);
                strY = Convert.ToString(y);
                if (x != stopValue && (4 * x - 0.5) != 0)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else if (x != stopValue && (4 * x - 0.5) == 0)
                {
                    y = 0;
                    strY = Convert.ToString(y);
                    File.AppendAllText(path, strY + Environment.NewLine);       // новая строка
                }
                else
                {
                    File.AppendAllText(path, strY);       // сохранить без переноса
                }
            }
            return path;
        }
    }
}
