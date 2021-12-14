using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int n2 = int.Parse(Console.ReadLine());
            numbers.Reverse();
            Func<int, int, bool> filter = (x, y) => x % y != 0;
            numbers = FilteredNumbers(numbers, n2, filter);
            Console.WriteLine(string.Join(" ", numbers));
        }


        public static List<int> FilteredNumbers(List<int> numbers, int number, Func<int, int, bool> filter)
        {
            List<int> listToReturn = new List<int>();
            foreach(var num in numbers)
            {
                if(filter(num, number))
                {
                    listToReturn.Add(num);
                }
            }

            return listToReturn;
        }
    }
}
