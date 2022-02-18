using System;

namespace _02.Armory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentSwordsSold = 0;
            int negotiatedCoints = 65;
            char[][] armory = ReadMatrix(n);
            int[] knightCoordiantes = FindPiece(armory, 'A');
            int knightRow = knightCoordiantes[0];
            int knightCol = knightCoordiantes[1];

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up") //row - 1
                {
                    armory[knightRow][knightCol] = '-';
                    if (isValidMove(knightRow - 1, knightCol, armory))
                    {
                        knightRow--;

                        if(char.IsDigit(armory[knightRow][knightCol]))
                        {
                            currentSwordsSold += int.Parse(armory[knightRow][knightCol].ToString());
                            armory[knightRow][knightCol] = 'A';
                        }
                        else if(armory[knightRow][knightCol] == 'M')
                        {
                            armory[knightRow][knightCol] = '-';
                            int[] teleportedLocation = FindPiece(armory, 'M');
                            knightRow = teleportedLocation[0];
                            knightCol = teleportedLocation[1];
                            armory[knightRow][knightCol] = 'A';
                        }
                        else
                        {
                            armory[knightRow][knightCol] = 'A';
                        }

                        if(currentSwordsSold >= negotiatedCoints)
                        {
                            Console.WriteLine($"Very nice swords, I will come back for more!\nThe king paid {currentSwordsSold} gold coins.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"I do not need more swords!\nThe king paid {currentSwordsSold} gold coins.");
                        break;
                    }
                }
                else if (command == "right") //col + 1
                {
                    armory[knightRow][knightCol] = '-';
                    if (isValidMove(knightRow, knightCol + 1, armory))
                    {
                        knightCol++;

                        if (char.IsDigit(armory[knightRow][knightCol]))
                        {
                            currentSwordsSold += int.Parse(armory[knightRow][knightCol].ToString());
                            armory[knightRow][knightCol] = 'A';
                        }
                        else if (armory[knightRow][knightCol] == 'M')
                        {
                            armory[knightRow][knightCol] = '-';
                            int[] teleportedLocation = FindPiece(armory, 'M');
                            knightRow = teleportedLocation[0];
                            knightCol = teleportedLocation[1];
                            armory[knightRow][knightCol] = 'A';
                        }
                        else
                        {
                            armory[knightRow][knightCol] = 'A';
                        }

                        if (currentSwordsSold >= negotiatedCoints)
                        {
                            Console.WriteLine($"Very nice swords, I will come back for more!\nThe king paid {currentSwordsSold} gold coins.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"I do not need more swords!\nThe king paid {currentSwordsSold} gold coins.");
                        break;
                    }
                }
                else if (command == "down") //row + 1
                {
                    armory[knightRow][knightCol] = '-';
                    if (isValidMove(knightRow + 1, knightCol, armory))
                    {
                        knightRow++;

                        if (char.IsDigit(armory[knightRow][knightCol]))
                        {
                            currentSwordsSold += int.Parse(armory[knightRow][knightCol].ToString());
                            armory[knightRow][knightCol] = 'A';
                        }
                        else if (armory[knightRow][knightCol] == 'M')
                        {
                            armory[knightRow][knightCol] = '-';
                            int[] teleportedLocation = FindPiece(armory, 'M');
                            knightRow = teleportedLocation[0];
                            knightCol = teleportedLocation[1];
                            armory[knightRow][knightCol] = 'A';
                        }
                        else
                        {
                            armory[knightRow][knightCol] = 'A';
                        }

                        if (currentSwordsSold >= negotiatedCoints)
                        {
                            Console.WriteLine($"Very nice swords, I will come back for more!\nThe king paid {currentSwordsSold} gold coins.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"I do not need more swords!\nThe king paid {currentSwordsSold} gold coins.");
                        break;
                    }
                }
                else if(command == "left") //col -1;
                {
                    armory[knightRow][knightCol] = '-';
                    if (isValidMove(knightRow, knightCol - 1, armory))
                    {
                        knightCol--;

                        if (char.IsDigit(armory[knightRow][knightCol]))
                        {
                            currentSwordsSold += int.Parse(armory[knightRow][knightCol].ToString());
                            armory[knightRow][knightCol] = 'A';
                        }
                        else if (armory[knightRow][knightCol] == 'M')
                        {
                            armory[knightRow][knightCol] = '-';
                            int[] teleportedLocation = FindPiece(armory, 'M');
                            knightRow = teleportedLocation[0];
                            knightCol = teleportedLocation[1];
                            armory[knightRow][knightCol] = 'A';
                        }
                        else
                        {
                            armory[knightRow][knightCol] = 'A';
                        }

                        if (currentSwordsSold >= negotiatedCoints)
                        {
                            Console.WriteLine($"Very nice swords, I will come back for more!\nThe king paid {currentSwordsSold} gold coins.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"I do not need more swords!\nThe king paid {currentSwordsSold} gold coins.");
                        break;
                    }
                }
            }

            PrintMaze(armory);
        }

        private static char[][] ReadMatrix(int n)
        {
            char[][] matrix = new char[n][];

            for (int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                matrix[i] = row;
            }

            return matrix;
        }

        private static int[] FindPiece(char[][] board, char symbol)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] == symbol)
                        return new int[] { i, j };
                }
            }

            return null;
        }

        private static void PrintMaze(char[][] maze)
        {
            for (int i = 0; i < maze.Length; i++)
            {
                Console.WriteLine(string.Join("", maze[i]));
            }
        }

        private static bool isValidMove(int row, int col, char[][] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 &&
                   col < matrix[row].Length;
        }
    }
}
