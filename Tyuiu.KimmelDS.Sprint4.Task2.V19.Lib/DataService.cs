using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KimmelDS.Sprint4.Task2.V19.Lib
{
    public class DataService : ISprint4Task2V19
    {
        public int Calculate(int[] array) => array.Where(x => x % 2 != 0).Sum();
    }
}
