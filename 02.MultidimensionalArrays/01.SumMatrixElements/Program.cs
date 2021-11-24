using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(", ");
            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);
            int[,] matrix = ReadMatrix(rows, columns);

            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(SumMatrix(matrix));
            
        }

        public static int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        public static int[,] ReadMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            for(int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for(int column = 0; column < columns; column++)
                {
                    matrix[row, column] = input[column];
                }
            }

            return matrix;
        }
    }
}
