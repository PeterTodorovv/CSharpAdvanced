using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNumbers = new Queue<int>();

            foreach(int number in input)
            {
                if(number % 2 == 0)
                {
                    evenNumbers.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
