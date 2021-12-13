using System;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> printUpper = PrintUpper;
            printUpper(words);

        }

        public static void PrintUpper(string[] words)
        {
            foreach(var word in words)
            {
                if (char.IsUpper(word[0]))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
