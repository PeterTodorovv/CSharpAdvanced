using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[,] matrix = ReadMatrix(size);
            string symbol = Console.ReadLine();
            FindSymbol(symbol, matrix);

        }

        private static void FindSymbol(string symbol, string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if(matrix[row, column] == symbol)
                    {
                        Console.WriteLine($"({row}, {column})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }

        public static string[,] ReadMatrix(int size)
        {
            string[,] matrix = new string[size, size];
            
            for(int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for(int column = 0; column < size; column++)
                {
                    matrix[row, column] = input[column].ToString();
                }
            }

            return matrix;
        }
    }
}
