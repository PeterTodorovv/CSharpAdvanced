using System;
using System.Linq;

namespace _01.Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = SumArray(array);
            Console.WriteLine(sum);
        }

        private static int SumArray(int[] array, int index = -1)
        {
            index++;
            if (index == array.Length)
            {
                return 0;
            }
            return  array[index] + SumArray(array, index);
        }
    }
}
