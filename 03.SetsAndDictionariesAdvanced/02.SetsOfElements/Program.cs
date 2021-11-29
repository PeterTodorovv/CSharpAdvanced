using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            int n = numbers[0];
            int m = numbers[1];

            for(int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set1.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set2.Add(number);
            }

            foreach(var number in set1)
            {
                if (set2.Contains(number))
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
