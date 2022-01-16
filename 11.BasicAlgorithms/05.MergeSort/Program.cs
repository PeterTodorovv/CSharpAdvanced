using System;
using System.Linq;

namespace _05.MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", SelectionSort(numbers)));
        }

        static int[] SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = numbers[i];
                int smallest = temp;
                int indexToSwap = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if(numbers[j] < smallest)
                    {
                        smallest = numbers[j];
                        indexToSwap = j;
                    }
                }

                numbers[i] = smallest;
                numbers[indexToSwap] = temp;
            }
            return numbers;
        }
    }
}
