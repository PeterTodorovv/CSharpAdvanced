using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Func<int[], int[]> filteredNumbers = Filter;
            Console.WriteLine(string.Join(", ", filteredNumbers(numbers)));

        }

        public static int[] Filter(int[] array)
        {
            List<int> filtered = new List<int>();

            foreach(int number in array.OrderBy(n => n))
            {
                if(number % 2 == 0)
                {
                    filtered.Add(number);
                }
            }

            return filtered.ToArray();
        }
    }
}
