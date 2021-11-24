using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(size);

            string input = Console.ReadLine();

            while(input != "END")
            {
                string[] splittedInput = input.Split();
                string command = splittedInput[0];
                int[] coordinates = { int.Parse(splittedInput[1]), int.Parse(splittedInput[2]) };
                if (coordinates[0] >= size || coordinates[0] < 0 || coordinates[1] >= size || coordinates[1] < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine();
                    continue;
                }

                switch (command)
                {
                    case "Add":
                        matrix[coordinates[0], coordinates[1]] += int.Parse(splittedInput[3]);
                        break;
                    case "Subtract":
                        matrix[coordinates[0], coordinates[1]] -= int.Parse(splittedInput[3]);
                        break;
                }
                input = Console.ReadLine();
            }

            PrintMatrix(matrix);
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

        public static int[,] ReadMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int column = 0; column < size; column++)
                {
                    matrix[row, column] = input[column];
                }
            }

            return matrix;
        }
    }
}
