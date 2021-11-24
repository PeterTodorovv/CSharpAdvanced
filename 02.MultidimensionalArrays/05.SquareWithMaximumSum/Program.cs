using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(", ");
            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);
            int[,] matrix = ReadMatrix(rows, columns);
            FindSum(matrix);
        }

        public static void FindSum(int[,] matrix)
        {
            int biggestSum = 0;
            int[] startingPoints = new int[2];
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                {
                    int currentSum = matrix[row, column] + matrix[row, column + 1] + matrix[row + 1, column] + matrix[row + 1, column + 1];
                    if(currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        startingPoints[0] = row;
                        startingPoints[1] = column;
                    }
                }
            }

            for(int row = startingPoints[0]; row < startingPoints[0] + 2; row++)
            {
                for (int column = startingPoints[1]; column < startingPoints[1] + 2; column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(biggestSum);
        }

        public static int[,] ReadMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = input[column];
                }
            }

            return matrix;
        }
    }
}
