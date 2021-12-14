using System;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Action<string[]> priner = x => Console.WriteLine(string.Join(Environment.NewLine, x));
            priner(words);
        }
    }
}
