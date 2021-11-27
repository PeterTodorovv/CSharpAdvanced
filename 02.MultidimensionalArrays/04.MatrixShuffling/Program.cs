using System;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(size[0]);
            int columns = int.Parse(size[1]);
            string[,] matrix = ReadMatrix(rows, columns);
            string input = Console.ReadLine();

            while(input != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if(command.Length != 5 || command[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                int[] first = { int.Parse(command[1]), int.Parse(command[2]) };
                int[] second = { int.Parse(command[3]), int.Parse(command[4]) };

                if(first[0] > rows || first[0] < 0 || second[0] > rows || second[0] < 0 
                    || first[1] > rows || first[1] < 0 || second[1] > rows || second[1] < 0)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                string element1 = matrix[first[0], first[1]];
                matrix[first[0], first[1]] = matrix[second[0], second[1]];
                matrix[second[0], second[1]] = element1;
                PrintMatrix(matrix);
                input = Console.ReadLine();
            }
        }

        public static void PrintMatrix(string[,] matrix)
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

        public static string[,] ReadMatrix(int rows, int columns)
        {
            string[,] matrix = new string[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int column = 0; column < columns; column++)
                {
                    matrix[row, column] = input[column];
                }
            }

            return matrix;
        }
    }
}
