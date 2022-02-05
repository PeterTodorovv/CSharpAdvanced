using System;

namespace _02.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            if (rows == 0)
                return;
            
            char[][] maze = ReadMaze(rows);
            int[] marioLocation = FindCharacter('M', maze);
            int marioX = marioLocation[1];
            int marioY = marioLocation[0];

            while (lives > 0)
            {
                string[] input = Console.ReadLine().Split();
                string direction = input[0];
                int bowserY = int.Parse(input[1]);
                int bowserX = int.Parse(input[2]);
                maze[bowserY][bowserX] = 'B';
                lives--;

                if (direction == "W") //up
                {
                    marioY--;
                    if (!isValidMove(marioY, marioX, maze))
                    {
                        maze[marioY + 1][marioX] = 'M';
                        marioY++;
                        continue;
                    }
                    maze[marioY + 1][marioX] = '-';
                    MakeATurn(marioY, marioX, lives, maze);
                }
                else if (direction == "D") //right
                {
                    marioX++;

                    if (!isValidMove(marioY, marioX, maze))
                    {
                        maze[marioY][marioX - 1] = 'M';
                        marioX--;
                        continue;
                    }

                    maze[marioY][marioX - 1] = '-';
                    MakeATurn(marioY, marioX, lives, maze);

                }
                else if (direction == "S") //down
                {
                    marioY++;

                    if (!isValidMove(marioY, marioX, maze))
                    {
                        maze[marioY - 1][marioX] = 'M';
                        marioY--;
                        continue;
                    }

                    maze[marioY - 1][marioX] = '-';
                    MakeATurn(marioY, marioX, lives, maze);
                }
                else if (direction == "A") //left
                {
                    marioX--;

                    if (!isValidMove(marioY, marioX, maze))
                    {
                        maze[marioY][marioX + 1] = 'M';
                        marioX++;
                        continue;
                    }

                    maze[marioY][marioX + 1] = '-';
                    MakeATurn(marioY, marioX, lives, maze);
                }

            }

            maze[marioY][marioX] = 'X';
            PrintMaze(maze);
        }

        public static void MakeATurn(int marioY, int marioX, int lives, char[][] maze)
        {

            if (maze[marioY][marioX] == '-')
            {
                Move(marioX, marioY, lives, maze);
            }
            else if (maze[marioY][marioX] == 'P')
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                maze[marioY][marioX] = '-';
                PrintMaze(maze);
                Environment.Exit(0);
            }
            else if (maze[marioY][marioX] == 'B')
            {
                lives -= 2;
                Move(marioX, marioY, lives, maze);
            }
        }
        private static bool isValidMove(int row, int col, char[][] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 &&
                   col < matrix[row].Length;
        }

        private static void Move(int marioX, int marioY, int lives, char[][] maze)
        {
            if (lives > 0)
                maze[marioY][marioX] = 'M';
            else
            {
                maze[marioY][marioX] = 'X';
                Console.WriteLine($"Mario died at {marioY};{marioX}.");
                PrintMaze(maze);
                Environment.Exit(0);
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
    }
}
