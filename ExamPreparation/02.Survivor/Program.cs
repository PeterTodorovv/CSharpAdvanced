using System;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            char[,] map = ReadMap(rows);

            int[] coordinatesOfArmy = FindLocation(map, 'A');
            int armyY = coordinatesOfArmy[0];
            int armyX = coordinatesOfArmy[1];

            while (true)
            {
                if (!StillAlive(armor))
                {
                    Console.WriteLine($"The army was defeated at {armyY};{armyX}.");
                    map[armyY, armyX] = 'X';
                    PrintMap(map);
                    return;
                }
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                int orcY = int.Parse(input[1]);
                int orcX = int.Parse(input[2]);
                map[orcY, orcX] = 'O';

                if (command == "up")
                {
                    
                    armor--;
                    if (armyY != 0)
                    {
                        if (map[armyY - 1, armyX] == '-')
                        {
                            map[armyY, armyX] = '-';
                            armyY--;
                            map[armyY, armyX] = 'A';
                        }
                        else if (map[armyY - 1, armyX] == 'O')
                        {
                            armor -= 2;

                            if (StillAlive(armor))
                            {
                                map[armyY, armyX] = '-';
                                armyY--;
                                map[armyY, armyX] = 'A';
                            }
                            else
                            {
                                Console.WriteLine($"The army was defeated at {armyY - 1};{armyX}.");
                                map[armyY, armyX] = '-';
                                armyY--;
                                map[armyY, armyX] = 'X';
                                PrintMap(map);
                                return;
                            }
                        }
                        else if (map[armyY - 1, armyX] == 'M')
                        {
                            map[armyY, armyX] = '-';
                            armyY--;
                            map[armyY, armyX] = '-';
                            break;
                        }
                    }
                }
                else if (command == "down")
                {
                    armor--;
                    if (armyY != rows - 1)
                    {
                        if (map[armyY + 1, armyX] == '-')
                        {
                            map[armyY, armyX] = '-';
                            armyY++;
                            map[armyY, armyX] = 'A';
                        }
                        else if (map[armyY + 1, armyX] == 'O')
                        {
                            armor -= 2;

                            if (StillAlive(armor))
                            {
                                map[armyY, armyX] = '-';
                                armyY++;
                                map[armyY, armyX] = 'A';
                            }
                            else
                            {
                                Console.WriteLine($"The army was defeated at {armyY + 1};{armyX}.");
                                map[armyY, armyX] = '-';
                                armyY++;
                                map[armyY, armyX] = 'X';
                                PrintMap(map);
                                return;
                            }
                        }
                        else if (map[armyY + 1, armyX] == 'M')
                        {
                            map[armyY, armyX] = '-';
                            armyY++;
                            map[armyY, armyX] = '-';
                            break;
                        }
                    }
                }
                else if (command == "left")
                {
                    armor--;
                    if (armyX != 0)
                    {
                        if (map[armyY, armyX - 1] == '-')
                        {
                            map[armyY, armyX] = '-';
                            armyX--;
                            map[armyY, armyX] = 'A';
                        }
                        else if (map[armyY, armyX - 1] == 'O')
                        {
                            armor -= 2;

                            if (StillAlive(armor))
                            {
                                map[armyY, armyX] = '-';
                                armyX--;
                                map[armyY, armyX] = 'A';
                            }
                            else
                            {
                                Console.WriteLine($"The army was defeated at {armyY};{armyX - 1}.");
                                map[armyY, armyX] = '-';
                                armyX--;
                                map[armyY, armyX] = 'X';
                                PrintMap(map);
                                return;
                            }
                        }
                        else if (map[armyY, armyX - 1] == 'M')
                        {
                            map[armyY, armyX] = '-';
                            armyX--;
                            map[armyY, armyX] = '-';
                            break;
                        }
                    }
                }
                else if (command == "right")
                {
                    armor--;
                    if (armyX != rows - 1)
                    {
                        if (map[armyY, armyX + 1] == '-')
                        {
                            map[armyY, armyX] = '-';
                            armyX++;
                            map[armyY, armyX] = 'A';
                        }
                        else if (map[armyY, armyX + 1] == 'O')
                        {
                            armor -= 2;

                            if (StillAlive(armor))
                            {
                                map[armyY, armyX] = '-';
                                armyX++;
                                map[armyY, armyX] = 'A';
                            }
                            else
                            {
                                Console.WriteLine($"The army was defeated at {armyY};{armyX + 1}.");
                                map[armyY, armyX] = '-';
                                armyX++;
                                map[armyY, armyX] = 'X';
                                PrintMap(map);
                                return;
                            }
                        }
                        else if (map[armyY, armyX + 1] == 'M')
                        {
                            map[armyY, armyX] = '-';
                            armyX++;
                            map[armyY, armyX] = '-';
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
            PrintMap(map);
        }

        private static bool StillAlive(int armor)
        {
            if (armor > 0)
                return true;
            return false;

        }

        private static int[] FindLocation(char[,] board, char symbol)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == symbol)
                        return new int[] { i, j };
                }
            }

            return null;
        }

        private static char[,] ReadMap(int rows)
        {
            string line = Console.ReadLine();
            char[,] map = new char[rows, line.Length];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < line.Length; j++)
                {
                    map[i, j] = line[j];
                }

                if(i != rows - 1)
                {
                    line = Console.ReadLine();
                }
            }

            return map;
        }

        private static void PrintMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
