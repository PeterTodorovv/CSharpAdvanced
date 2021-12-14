using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Select(x => $"Sir {x}").ToArray();

            Action<string[]> printer = x => Console.WriteLine(string.Join(Environment.NewLine, x));
            printer(input);
        }
    }
}
