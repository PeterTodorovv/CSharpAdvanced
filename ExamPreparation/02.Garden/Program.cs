using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Garden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = size[0];
            int m = size[1];
            int[,] garden = new int[n, m];
            List<int[]> flowers = new List<int[]>();

            string[] input = Console.ReadLine().Split(' ');

            while(input[0] != "Bloom")
            {
                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);
                if(!isValidMove(row, col, garden))
                {
                    Console.WriteLine("Invalid coordinates.");
                    input = Console.ReadLine().Split(' ');
                    continue;
                }
                garden[row, col] = -1;
                flowers.Add(new int[] { row, col });
                input = Console.ReadLine().Split(' ');
            }

            foreach(var coordinates in flowers)
            {
                int row = coordinates[0];
                int col = coordinates[1];

                for(int i = 0; i < garden.GetLength(0); i++)
                {
                    garden[i, col] += 1;
                }

                for (int i = 0; i < garden.GetLength(0); i++)
                {
                    garden[row, i] += 1;
                }
            }

            PrintGarden(garden);
        }




        private static bool isValidMove(int row, int col, int[,] matrix)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 &&
                   col < matrix.GetLength(1);
        }

        private static void PrintGarden(int[,] garden)
        {
            for (int i = 0; i < garden.GetLength(0); i++)
            {
                for(int j = 0; j < garden.GetLength(1); j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
