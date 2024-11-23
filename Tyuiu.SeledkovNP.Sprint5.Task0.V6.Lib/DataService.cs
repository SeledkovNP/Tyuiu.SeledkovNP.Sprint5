using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SeledkovNP.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double y = (4 - Math.Pow(x, 3)) / (Math.Pow(x, 2));
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
