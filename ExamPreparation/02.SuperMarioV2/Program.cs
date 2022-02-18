using System;

namespace _02.SuperMarioV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[][] maze = ReadMaze(rows);
            int[] marioLocation = FindCharacter('M', maze);
            int marioX = marioLocation[1];
            int marioY = marioLocation[0];

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string direction = input[0];
                int bowserY = int.Parse(input[1]);
                int bowserX = int.Parse(input[2]);
                maze[bowserY][bowserX] = 'B';
                lives--;


                if (direction == "W") //up
                {
                    if(isValidMove(marioY - 1, marioX, maze))
                    {
                        maze[marioY][marioX] = '-';
                        marioY--;

                        if(maze[marioY][marioX] == 'P')
                        {
                            maze[marioY][marioX] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            PrintMaze(maze);
                            return;
                        }
                        else if(maze[marioY][marioX] == 'B')
                        {
                            lives -= 2;
                            if(lives <= 0)
                            {
                                maze[marioY][marioX] = 'X';
                                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                                PrintMaze(maze);
                                return;
                            }
                        }
                        else if(maze[marioY][marioX] == '-')
                        {
                            if (lives <= 0)
                            {
                                maze[marioY][marioX] = 'X';
                                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                                PrintMaze(maze);
                                return;
                            }
                        }
                    }
                }
                else if (direction == "D") //right
                {
                    if (isValidMove(marioY , marioX + 1, maze))
                    {
                        maze[marioY][marioX] = '-';
                        marioX++;

                        if (maze[marioY][marioX] == 'P')
                        {
                            maze[marioY][marioX] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            PrintMaze(maze);
                            return;
                        }
                        else if (maze[marioY][marioX] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                maze[marioY][marioX] = 'X';
                                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                                PrintMaze(maze);
                                return;
                            }
                        }
                        else if (maze[marioY][marioX] == '-')
                        {
                            if (lives <= 0)
                            {
                                maze[marioY][marioX] = 'X';
                                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                                PrintMaze(maze);
                                return;
                            }
                        }
                    }
                }
                else if (direction == "S") //down
                {
                    if (isValidMove(marioY + 1, marioX, maze))
                    {
                        maze[marioY][marioX] = '-';
                        marioY++;

                        if (maze[marioY][marioX] == 'P')
                        {
                            maze[marioY][marioX] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            PrintMaze(maze);
                            return;
                        }
                        else if (maze[marioY][marioX] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                maze[marioY][marioX] = 'X';
                                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                                PrintMaze(maze);
                                return;
                            }
                        }
                        else if (maze[marioY][marioX] == '-')
                        {
                            if (lives <= 0)
                            {
                                maze[marioY][marioX] = 'X';
                                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                                PrintMaze(maze);
                                return;
                            }
                        }
                    }
                }
                else if (direction == "A") //left
                {
                    if (isValidMove(marioY, marioX - 1, maze))
                    {
                        maze[marioY][marioX] = '-';
                        marioX--;

                        if (maze[marioY][marioX] == 'P')
                        {
                            maze[marioY][marioX] = '-';
                            Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                            PrintMaze(maze);
                            return;
                        }
                        else if (maze[marioY][marioX] == 'B')
                        {
                            lives -= 2;
                            if (lives <= 0)
                            {
                                maze[marioY][marioX] = 'X';
                                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                                PrintMaze(maze);
                                return;
                            }
                        }
                        else if (maze[marioY][marioX] == '-')
                        {
                            if (lives <= 0)
                            {
                                maze[marioY][marioX] = 'X';
                                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                                PrintMaze(maze);
                                return;
                            }
                        }
                    }
                }
            }
        }

        private static bool isValidMove(int row, int col, char[][] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 &&
                   col < matrix[row].Length;
        }

        private static char[][] ReadMaze(int rows)
        {
            char[][] maze = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                maze[i] = row;
            }

            return maze;
        }

        private static void PrintMaze(char[][] maze)
        {
            for (int i = 0; i < maze.Length; i++)
            {
                Console.WriteLine(string.Join("", maze[i]));
            }
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


    }
}
