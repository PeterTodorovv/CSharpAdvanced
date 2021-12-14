using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int> findSmallest = FindSmallest;
            Console.WriteLine(findSmallest(numbers));

        }

        public static int FindSmallest(int[] numbers)
        {
            int smallest = int.MaxValue;

            foreach(var number in numbers)
            {
                if (number < smallest)
                    smallest = number;
            }

            return smallest;
        }
    }
}
