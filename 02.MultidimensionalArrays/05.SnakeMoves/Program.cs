using System;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);
            char[,] matrix = new char[rows, columns];
            string snake = Console.ReadLine();
            int position = 0;

            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < columns; col++)
                {
                    matrix[row, col] = snake[position];
                    position++;
                    if (position >= snake.Length) position = 0;
                }

                row++;
                if (row >= rows)
                    continue;

                for (int col = columns - 1; col >= 0; col--)
                {
                    matrix[row, col] = snake[position];
                    position++;
                    if (position >= snake.Length) position = 0;
                }
            }

            PrintMatrix(matrix);
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column]);
                }
                Console.WriteLine();
            }
        }
    }
}
