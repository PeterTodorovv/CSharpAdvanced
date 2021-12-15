using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            foreach(string name in names.Where(name => name.Length <= n))
            {
                Console.WriteLine(name);
            }
        }
    }
}
