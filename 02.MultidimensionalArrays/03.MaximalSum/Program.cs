using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);
            int[,] matrix = ReadMatrix(rows, columns);
            int maxSum = 0;
            int[] startingPoint = {0, 0};

            for(int row = 1; row < rows - 1; row++)
            {
                for(int col = 1; col < columns - 1; col++)
                {
                    int currentSum = 0;
                    currentSum += matrix[row - 1, col - 1] + matrix[row - 1, col] + matrix[row - 1, col + 1]
                        + matrix[row, col - 1] + matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col - 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        startingPoint[0] = row - 1;
                        startingPoint[1] = col - 1;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = startingPoint[0]; row < startingPoint[0] + 3; row++)
            {
                for (int col = startingPoint[1]; col < startingPoint[1] + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        public static int[,] ReadMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = input[column];
                }
            }

            return matrix;
        }
    }
}
