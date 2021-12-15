using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int, int[], bool> isDividable = IsDividable;
            Func<int, int[], Func<int, int[], bool>, List<int>> filter = Filter;

            List<int> numbers = filter(n, dividers, isDividable);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static bool IsDividable(int num, int[] dividers)
        {
            foreach (var divider in dividers)
            {
                if (num % divider != 0)
                    return false;
            }
            return true;
        }

        static List<int> Filter(int n, int[] dividers, Func<int, int[], bool> isDividable)
        {
            List<int> numbers = new List<int>();

            for(int i = 1; i <= n; i++)
            {
                if (isDividable(i, dividers))
                    numbers.Add(i);
            }

            return numbers;
        }
    }
}
