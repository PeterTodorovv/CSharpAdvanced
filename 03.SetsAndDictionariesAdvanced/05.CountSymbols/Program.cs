using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            string text = Console.ReadLine();

            foreach(char letter in text)
            {
                if (!characters.ContainsKey(letter))
                {
                    characters.Add(letter, 0);
                }

                characters[letter]++;
            }

            foreach(var element in characters.OrderBy(c => c.Key))
            {
                Console.WriteLine($"{element.Key}: {element.Value} time/s");
            }
        }
    }
}
