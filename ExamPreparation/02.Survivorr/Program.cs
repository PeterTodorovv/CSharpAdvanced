using System;
using System.Linq;

namespace _02.Survivorr
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int myTokens = 0;
            int oponentsTokens = 0;
            char[][] beach = ReadBeach(n);
            string[] input = Console.ReadLine().Split();
            
            while(input[0] != "Gong")
            {
                string command = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);

                if(command == "Find" && isValid(row, col, beach) && beach[row][col] == 'T')
                {
                    myTokens++;
                    beach[row][col] = '-';
                }
                else if(command == "Opponent" && isValid(row, col, beach) && beach[row][col] == 'T')
                {
                    oponentsTokens++;
                    beach[row][col] = '-';
                    string direction = input[3];

                    if (direction == "right")
                    {
                        for (int i = col + 1; i <= col + 3; i++)
                        {
                            if (isValid(row, i, beach))
                            {
                                if (beach[row][i] == 'T')
                                {
                                    oponentsTokens++;
                                    beach[row][i] = '-';
                                }
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        for (int i = col - 1; i >= col - 3; i--)
                        {
                            if (isValid(row, i, beach))
                            {
                                if (beach[row][i] == 'T')
                                {
                                    oponentsTokens++;
                                    beach[row][i] = '-';
                                }
                            }
                        }
                    }
                    else if (direction == "up")
                    {
                        for (int i = row - 1; i >= row - 3; i--)
                        {
                            if(isValid(i, col, beach))
                            {
                                if(beach[i][col] == 'T')
                                {
                                    oponentsTokens++;
                                    beach[i][col] = '-';
                                }
                            }
                        }
                    }
                    else if(direction == "down")
                    {
                        for (int i = row + 1; i <= row + 3; i++)
                        {
                            if (isValid(i, col, beach))
                            {
                                if (beach[i][col] == 'T')
                                {
                                    oponentsTokens++;
                                    beach[i][col] = '-';
                                }
                            }
                        }
                    }

                }


                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            PrintBeach(beach);
            Console.WriteLine($"Collected tokens: {myTokens}");
            Console.WriteLine($"Opponent's tokens: {oponentsTokens}");
        }

        private static bool isValid(int row, int col, char[][] beach)
        {
            if(row >= 0 && row < beach.Length && col >= 0 && col < beach[row].Length)
            {
                return true;
            }
            return false;
        }

        private static char[][] ReadBeach(int n)
        {
            char[][] beach = new char[n][];

            for(int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                beach[i] = row;
            }

            return beach;
        }

        private static void PrintBeach(char[][] beach)
        {
            for (int i = 0; i < beach.Length; i++)
            {
                Console.WriteLine(string.Join(" ", beach[i]));
            }

        }
    }
}
