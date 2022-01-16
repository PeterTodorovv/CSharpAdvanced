using System;
using System.Linq;

namespace _06.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Index of {number} is {BinarySearch(array, number)}");

        }

        private static int BinarySearch(int[] array, int number)
        {
            int low = 0;
            int high = array.Length - 1;

            while(low <= high)
            {
                int mid = low + (high - low) / 2;

                if(array[mid] == number)
                {
                    return mid;
                }
                else if(array[mid] > number)
                {
                    high = mid - 1;
                }
                else if(array[mid] < number)
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
    }
}
