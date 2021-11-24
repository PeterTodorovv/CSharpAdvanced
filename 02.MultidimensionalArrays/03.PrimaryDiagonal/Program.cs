using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(size, size);
            Console.WriteLine(DiagonalSum(matrix));

        }

        public static int DiagonalSum(int[,] matrix)
        {
            int sum = 0;

            for (int index = 0; index < matrix.GetLength(0); index++)
            {
                sum += matrix[index, index];
            }

            return sum;
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
