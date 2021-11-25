using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];
            char[,] matrix = ReadMatrix(rows, cols);
            int squares = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if(matrix[row, col] == matrix[row  + 1, col] && matrix[row, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row, col + 1])
                    {
                        squares++;
                    }
                }
            }

            Console.WriteLine(squares);
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];

            for(int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for(int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            return matrix;
        }
    }
}
