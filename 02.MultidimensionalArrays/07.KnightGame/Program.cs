using System;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = ReadMatrix(size);

            int highestDanger = -1;
            int removedKnights = 0;

            while(highestDanger != 0)
            {
                highestDanger = 0;
                int[] position = new int[2];
                for (int row = 0; row < size; row++)
                {
                    int currentDanger = 0;
                    for(int col = 0; col < size; col++)
                    {
                        if(matrix[row, col] == 'K')
                        {
                            if (IsInside(matrix, row - 2, col - 1))
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                {
                                    currentDanger++;
                                }
                            }
                            if (IsInside(matrix, row - 1, col - 2))
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                {
                                    currentDanger++;
                                }
                            }
                            if (IsInside(matrix, row + 1, col - 2))
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                {
                                    currentDanger++;
                                }
                            }
                                
                            if (IsInside(matrix, row + 2, col - 1))
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                {
                                    currentDanger++;
                                }
                            }
                                
                            if (IsInside(matrix, row - 2, col + 1))
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    currentDanger++;
                                }
                            }

                            if (IsInside(matrix, row - 1, col + 2))
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                {
                                    currentDanger++;
                                }
                            }

                            if (IsInside(matrix, row + 1, col + 2))
                            {
                                if (matrix[row + 1, col + 2] == 'K')
                                {
                                    currentDanger++;
                                }
                            }

                            if (IsInside(matrix, row + 2, col + 1))
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                {
                                    currentDanger++;
                                }
                            }
                            if (currentDanger > highestDanger)
                            {
                                highestDanger = currentDanger;
                                position[0] = row;
                                position[1] = col;
                            }
                            currentDanger = 0;
                        }
                    }
                   
                }
                if (highestDanger > 0)
                {
                    matrix[position[0], position[1]] = '0';
                    removedKnights++;
                }
            }
            Console.WriteLine(removedKnights);

        }

        private static bool IsInside(char[,] matrix, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < matrix.GetLength(0)
                && targetCol >= 0 && targetCol < matrix.GetLength(1);
        }

        private static char[,] ReadMatrix(int size)
        {
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
