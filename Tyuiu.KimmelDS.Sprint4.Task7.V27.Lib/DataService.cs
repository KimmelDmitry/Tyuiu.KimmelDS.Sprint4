using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KimmelDS.Sprint4.Task7.V27.Lib
{
    public class DataService : ISprint4Task7V27
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = (int)(value[i * m + j] - '0'); 

            return Enumerable.Range(0, n).SelectMany(i =>
                   Enumerable.Range(0, m).Select(j => matrix[i, j]))
                   .Count(x => x % 2 == 0);
        }
    }
}
