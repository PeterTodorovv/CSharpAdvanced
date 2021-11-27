using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(size);
            string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Explode(matrix, bombs);

            int activeCells = 0;
            int sum = 0;
            foreach(int number in matrix)
            {
                if (number > 0)
                {
                    activeCells++;
                    sum += number;
                }
            }
            Console.WriteLine($"Alive cells: {activeCells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix);
        }

        private static void Explode(int[,] matrix, string[] bombs)
        {
            foreach (var bombLocation in bombs)
            {
                int[] cordinates = bombLocation.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int bombPower = matrix[cordinates[0], cordinates[1]];
                if (bombPower < 1)
                    continue;

                if (IsInside(matrix, cordinates[0] - 1, cordinates[1] - 1))
                {
                    if (matrix[cordinates[0] - 1, cordinates[1] - 1] > 0)
                        matrix[cordinates[0] - 1, cordinates[1] - 1] -= bombPower;
                }

                if (IsInside(matrix, cordinates[0], cordinates[1] - 1))
                {
                    if (matrix[cordinates[0], cordinates[1] - 1] > 0)
                        matrix[cordinates[0], cordinates[1] - 1] -= bombPower;
                }

                if (IsInside(matrix, cordinates[0] + 1, cordinates[1] - 1))
                {
                    if (matrix[cordinates[0] + 1, cordinates[1] - 1] > 0)
                        matrix[cordinates[0] + 1, cordinates[1] - 1] -= bombPower;
                }


                if (IsInside(matrix, cordinates[0] - 1, cordinates[1]))
                {
                    if (matrix[cordinates[0] - 1, cordinates[1]] > 0)
                        matrix[cordinates[0] - 1, cordinates[1]] -= bombPower;
                }

                if (IsInside(matrix, cordinates[0] + 1, cordinates[1]))
                {
                    if (matrix[cordinates[0] + 1, cordinates[1]] > 0)
                        matrix[cordinates[0] + 1, cordinates[1]] -= bombPower;
                }


                if (IsInside(matrix, cordinates[0] - 1, cordinates[1] + 1))
                {
                    if (matrix[cordinates[0] - 1, cordinates[1] + 1] > 0)
                        matrix[cordinates[0] - 1, cordinates[1] + 1] -= bombPower;
                }

                if (IsInside(matrix, cordinates[0], cordinates[1] + 1))
                {
                    if (matrix[cordinates[0], cordinates[1] + 1] > 0)
                        matrix[cordinates[0], cordinates[1] + 1] -= bombPower;
                }

                if (IsInside(matrix, cordinates[0] + 1, cordinates[1] + 1))
                {
                    if (matrix[cordinates[0] + 1, cordinates[1] + 1] > 0)
                        matrix[cordinates[0] + 1, cordinates[1] + 1] -= bombPower;
                }
            }

            foreach (var bombLocation in bombs)
            {
                int[] cordinates = bombLocation.Split(",",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[cordinates[0], cordinates[1]] = 0;
            }
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(int[,] matrix, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < matrix.GetLength(0)
                && targetCol >= 0 && targetCol < matrix.GetLength(1);
        }

        private static int[,] ReadMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
