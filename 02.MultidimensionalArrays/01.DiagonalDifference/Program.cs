using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(size);

            int diagonal1 = 0;
            for(int i = 0; i < size; i++)
            {
                diagonal1 += matrix[i, i];
            }

            int diagonal2 = 0;
            int col = size - 1;
            for (int row = 0; row < size; row++)
            {
                diagonal2 += matrix[row,col];
                col--; ;
            }

            Console.WriteLine(Math.Abs(diagonal1 - diagonal2));
        }

        private static int[,] ReadMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            for(int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
