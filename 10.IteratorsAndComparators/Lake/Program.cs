using System;
using System.Linq;

namespace Lake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] path = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake lake = new Lake(path);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
