using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(", ");
            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);
            int[,] matrix = ReadMatrix(rows, columns);
            PrintColumns(matrix);
        }

        public static void PrintColumns(int[,] matrix)
        {
            for(int column = 0; column < matrix.GetLength(1); column++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, column];
                }

                Console.WriteLine(sum);
            }
        }

        public static int[,] ReadMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = input[column];
                }
            }

            return matrix;
        }
    }
}
