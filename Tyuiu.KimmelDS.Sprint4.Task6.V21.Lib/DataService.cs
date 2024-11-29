using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KimmelDS.Sprint4.Task6.V21.Lib
{
    public class DataService : ISprint4Task6V21
    {
        public int Calculate(string[] array) => array.Count(x => x.Length < 8);
    }
}
