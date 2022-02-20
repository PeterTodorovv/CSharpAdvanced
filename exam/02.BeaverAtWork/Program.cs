using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BeaverAtWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] pond = ReadPond(n);
            List<char> branches = new List<char>();
            int woodCollected = 0;
            int[] beeverLocation = FindCharacter('B', pond);
            int bRow = beeverLocation[0];
            int bCol = beeverLocation[1];
            string input = Console.ReadLine();

            while(input != "end")
            {
                if (input == "up") //row - 1
                {
                    if (!isValidMove(bRow - 1, bCol, pond))
                    {
                        Drop(branches);
                    }
                    else
                    {
                        pond[bRow][bCol] = '-';
                        bRow--;

                        if (pond[bRow][bCol] == '-')
                        {
                            pond[bRow][bCol] = 'B';
                        }
                        else if (char.IsLower(pond[bRow][bCol]))
                        {
                            branches.Add(pond[bRow][bCol]);
                            pond[bRow][bCol] = 'B';
                            if (CheckIfWins(pond))
                            {
                                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                PrintPond(pond);
                                return;
                            }
                        }
                        else if (pond[bRow][bCol] == 'F')
                        {
                            pond[bRow][bCol] = '-';

                            if (bRow != 0)
                            {
                                bRow = 0;
                                if (char.IsLower(pond[bRow][bCol]))
                                {
                                    branches.Add(pond[bRow][bCol]);
                                }
                                pond[0][bCol] = 'B';
                                if (CheckIfWins(pond))
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                    PrintPond(pond);
                                    return;
                                }
                            }
                            else
                            {
                                bRow = pond.Length - 1;
                                if (char.IsLower(pond[bRow][bCol]))
                                {
                                    branches.Add(pond[bRow][bCol]);
                                }
                                pond[pond.Length - 1][bCol] = 'B';
                                if (CheckIfWins(pond))
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                    PrintPond(pond);
                                    return;
                                }
                            }
                        }
                    }
                }
                else if (input == "right") //col + 1
                {
                    if (!isValidMove(bRow, bCol + 1, pond))
                    {
                        Drop(branches);
                    }
                    else
                    {
                        pond[bRow][bCol] = '-';
                        bCol++;

                        if (pond[bRow][bCol] == '-')
                        {
                            pond[bRow][bCol] = 'B';
                        }
                        else if (char.IsLower(pond[bRow][bCol]))
                        {
                            branches.Add(pond[bRow][bCol]);
                            woodCollected++;
                            pond[bRow][bCol] = 'B';
                            if (CheckIfWins(pond))
                            {
                                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                PrintPond(pond);
                                return;
                            }
                        }
                        else if (pond[bRow][bCol] == 'F')
                        {
                            pond[bRow][bCol] = '-';

                            if (bCol != pond.Length - 1)
                            {
                                bCol = pond.Length - 1;
                                if (char.IsLower(pond[bRow][bCol]))
                                {
                                    branches.Add(pond[bRow][bCol]);
                                }
                                pond[bRow][pond.Length - 1] = 'B';
                                if (CheckIfWins(pond))
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                    PrintPond(pond);
                                    return;
                                }
                            }
                            else
                            {
                                bCol = 0;
                                if (char.IsLower(pond[bRow][0]))
                                {
                                    branches.Add(pond[bRow][bCol]);
                                }
                                pond[bRow][0] = 'B';
                                if (CheckIfWins(pond))
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                    PrintPond(pond);
                                    return;
                                }
                            }
                        }
                    }
                }
                else if (input == "down")  //row + 1
                {
                    if (!isValidMove(bRow + 1, bCol, pond))
                    {
                        Drop(branches);
                    }
                    else
                    {
                        pond[bRow][bCol] = '-';
                        bRow++;

                        if (pond[bRow][bCol] == '-')
                        {
                            pond[bRow][bCol] = 'B';
                        }
                        else if (char.IsLower(pond[bRow][bCol]))
                        {
                            branches.Add(pond[bRow][bCol]);
                            pond[bRow][bCol] = 'B';
                            if (CheckIfWins(pond))
                            {
                                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                PrintPond(pond);
                                return;
                            }
                        }
                        else if (pond[bRow][bCol] == 'F')
                        {
                            pond[bRow][bCol] = '-';

                            if (bRow != pond.Length - 1)
                            {
                                bRow = pond.Length - 1;
                                if (char.IsLower(pond[pond.Length -1][bCol]))
                                {
                                    branches.Add(pond[bRow][bCol]);
                                }
                                pond[pond.Length - 1][bCol] = 'B';
                                if (CheckIfWins(pond))
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                    PrintPond(pond);
                                    return;
                                }
                            }
                            else
                            {
                                bRow = 0;
                                if (char.IsLower(pond[0][bCol]))
                                {
                                    branches.Add(pond[bRow][bCol]);
                                }
                                pond[0][bCol] = 'B';

                                if (CheckIfWins(pond))
                                {
                                    Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                    PrintPond(pond);
                                    return;
                                }
                            }
                        }
                    }
                }
                else if (input == "left") //col -1
                {
                    if (!isValidMove(bRow, bCol - 1, pond))
                    {
                        Drop(branches);
                    }
                    else
                    {
                        pond[bRow][bCol] = '-';
                        bCol--;

                        if (pond[bRow][bCol] == '-')
                        {
                            pond[bRow][bCol] = 'B';
                        }
                        else if (char.IsLower(pond[bRow][bCol]))
                        {
                            branches.Add(pond[bRow][bCol]);
                            woodCollected++;
                            pond[bRow][bCol] = 'B';
                        }
                        else if (pond[bRow][bCol] == 'F')
                        {
                            pond[bRow][bCol] = '-';

                            if (bCol != 0)
                            {
                                bCol = 0;
                                if (char.IsLower(pond[bRow][bCol]))
                                {
                                    branches.Add(pond[bRow][bCol]);
                                    woodCollected++;
                                }
                                pond[bRow][0] = 'B';
                            }
                            else
                            {
                                bCol = pond.Length - 1;

                                if (char.IsLower(pond[bRow][pond.Length - 1]))
                                {
                                    branches.Add(pond[bRow][bCol]);
                                    woodCollected++;
                                }
                                pond[bRow][pond.Length - 1] = 'B';
                            }

                            if (CheckIfWins(pond))
                            {
                                Console.WriteLine($"The Beaver successfully collect {branches.Count} wood branches: {string.Join(", ", branches)}.");
                                PrintPond(pond);
                                return;
                            }
                        }
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"The Beaver failed to collect every wood branch. There are {BranchesLeft(pond)} branches left.");
            PrintPond(pond);

        }



        private static void Drop(List<char> branches)
        {
            if (branches.Count > 0)
            {
                branches.RemoveAt(branches.Count - 1);
            }
        }

        private static int BranchesLeft(char[][] pond)
        {
            int branches = 0;

            for (int i = 0; i < pond.Length; i++)
            {
                for (int j = 0; j < pond.Length; j++)
                {
                    if(char.IsLower(pond[i][j]))
                        branches++;
                }
            }

            return branches;
        }
        private static char[][] ReadPond(int rows)
        {
            char[][] pond = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                pond[i] = new char[rows];
                string[] row = Console.ReadLine().Split(" ");
                for(int j = 0; j < row.Length; j++)
                {
                    pond[i][j] = char.Parse(row[j]);
                }
            }

            return pond;
        }
        private static void PrintPond(char[][] maze)
        {
            for (int i = 0; i < maze.Length; i++)
            {
                Console.WriteLine(string.Join(" ", maze[i]));
            }
        }
        private static bool isValidMove(int row, int col, char[][] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 &&
                   col < matrix[row].Length;
        }

        private static int[] FindCharacter(char character, char[][] maze)
        {
            int[] coordinates = new int[2];
            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; j < maze[i].Length; j++)
                {
                    if (maze[i][j] == character)
                    {
                        coordinates[0] = i;
                        coordinates[1] = j;
                        break;
                    }
                }
            }

            return coordinates;
        }

        private static bool CheckIfWins(char[][] pond)
        {
            return !pond.Any(p => p.Any(p2 => char.IsLower(p2)));
        }
    }
}
