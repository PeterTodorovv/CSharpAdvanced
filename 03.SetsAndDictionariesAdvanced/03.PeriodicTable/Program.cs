using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> elements = new SortedSet<string>();
            int lines = int.Parse(Console.ReadLine());

            for(int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                foreach(string element in input)
                {
                    elements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
