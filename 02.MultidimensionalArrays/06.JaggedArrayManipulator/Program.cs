using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] matrix = new double[rows][];

            for(int row = 0; row < rows; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if(matrix[row].Length == matrix[row + 1].Length)
                {
                    for(int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }
                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }
                }
            }

            string input = Console.ReadLine();

            while(input != "End")
            {
                string[] splittedInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = splittedInput[0];
                int row = int.Parse(splittedInput[1]);
                int col = int.Parse(splittedInput[2]);
                double value = double.Parse(splittedInput[3]);

                if(row > rows || row < 0 || matrix[row].Length <= col || col < 0)
                {
                    input = Console.ReadLine();
                    continue;
                }

                switch (command)
                {
                    case "Add":
                        matrix[row][col] += value;
                        break;
                    case "Subtract":
                        matrix[row][col] -= value;
                        break;
                }


                input = Console.ReadLine();
            }

            for(int row = 0; row < rows; row++)
            {
                foreach(var element in matrix[row])
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
