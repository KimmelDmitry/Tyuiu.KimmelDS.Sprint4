using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KimmelDS.Sprint4.Task4.V1.Lib
{
    public class DataService : ISprint4Task4V1
    {
        public int Calculate(int[,] matrix) =>
            Enumerable.Range(0, matrix.GetLength(0)) 
                     .SelectMany(i => Enumerable.Range(0, matrix.GetLength(1)) 
                     .Select(j => matrix[i, j])) 
                     .Where(x => x % 2 == 0) 
                     .Sum(); 


    }
}
