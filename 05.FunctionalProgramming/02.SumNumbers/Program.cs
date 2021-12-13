using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Func<int[], int> sum = Sum;
            Console.WriteLine(numbers.Length);
            Console.WriteLine(sum(numbers));


        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
