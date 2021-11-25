using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];

            int cols = 1;

            for(int row = 0; row < triangle.Length; row++)
            {
                triangle[row] = new long[cols];
                triangle[row][0] = 1;
                triangle[row][triangle[row].Length - 1] = 1;

                for(int i = 1; i < triangle[row].Length - 1; i++)
                {
                    triangle[row][i] = triangle[row - 1][i - 1] + triangle[row - 1][i];
                }
                cols++;
            }

            foreach(var line in triangle)
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
