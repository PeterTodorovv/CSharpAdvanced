using System;

namespace _02.PawnWars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] chessboard = ReadChessboard();
            int[] coordinatesWhite = FindPiece(chessboard, 'w');
            int whiteX = coordinatesWhite[1];
            int whiteY = coordinatesWhite[0];
            int[] coordinatesBlack = FindPiece(chessboard, 'b');
            int blackX = coordinatesBlack[1];
            int blackY = coordinatesBlack[0];

            while (true)
            {
                if(whiteX != 0)
                {
                    if (chessboard[whiteY - 1, whiteX - 1] == 'b')
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(whiteX + 97 - 1)}{RightPosition(whiteY - 1)}.");
                        return;
                    }
                }
                if(whiteX != 7)
                {
                    if (chessboard[whiteY - 1, whiteX + 1] == 'b')
                    {
                        Console.WriteLine($"Game over! White capture on {(char)(whiteX + 97 + 1)}{RightPosition(whiteY - 1)}.");
                        return;
                    }
                }
                

                chessboard[whiteY - 1, whiteX] = 'w';
                chessboard[whiteY, whiteX] = '-';
                whiteY--;

                if(whiteY == 0)
                {
                    Console.WriteLine($"Game over! White pawn is promoted to a queen at {(char)(whiteX + 97)}8.");
                    return;
                }

                if(blackX != 0)
                {
                    if (chessboard[blackY + 1, blackX - 1] == 'w')
                    {
                        Console.WriteLine($"Game over! Black capture on {(char)(blackX + 97 - 1)}{RightPosition(blackY + 1)}.");
                        return;
                    }
                }
                if(blackX != 7)
                {
                    if (chessboard[blackY + 1, blackX + 1] == 'w')
                    {

                        Console.WriteLine($"Game over! Black capture on {(char)(blackX + 97 + 1)}{RightPosition(blackY + 1)}.");
                        return;
                    }
                }

                
                chessboard[blackY + 1, blackX] = 'b';
                chessboard[blackY, blackX] = '-';
                blackY++;

                if (blackY == 7)
                {
                    Console.WriteLine($"Game over! Black pawn is promoted to a queen at {(char)(blackX + 97)}1.");
                    return;
                }
            }
        }

        public static int RightPosition(int n)
        {
            if (n == 0)
                return 8;
            if (n == 1)
                return 7;
            if (n == 2)
                return 6;
            if (n == 3)
                return 5;
            if (n == 4)
                return 4;
            if (n == 5)
                return 3;
            if (n == 6)
                return 2;
            else
                return 1;

        }

        private static int[] FindPiece(char[,] board, char symbol)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] == symbol)
                        return new int[] { i, j };
                }
            }

            return null;
        }

        private static char[,] ReadChessboard()
        {
            char[,] borad = new char[8, 8];
            for(int i = 0; i < 8; i++)
            {
                string line = Console.ReadLine();
                for(int j = 0; j < 8; j++)
                {
                    borad[i, j] = line[j];
                }
            }

            return borad;
        }
    }
}
