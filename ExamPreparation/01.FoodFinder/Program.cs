using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FoodFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> vowels = new Queue<char>(Console.ReadLine().Split().Select(char.Parse).ToArray());
            Stack<char> consonants = new Stack<char>(Console.ReadLine().Split().Select(char.Parse).ToArray());
            string[] words = new string[] {"pear", "flour", "pork", "olive"};
            List<char> lettersContained = new List<char>();
            List<string> wordsToPrint = new List<string>();

            while(consonants.Count > 0)
            {
                char vowel = vowels.Dequeue();
                char consonant = consonants.Pop();

                foreach(var word in words)
                {
                    if (word.Contains(vowel))
                        lettersContained.Add(vowel);

                    if (word.Contains(consonant))
                        lettersContained.Add(consonant);
                }

                vowels.Enqueue(vowel);
            }

            foreach(var word in words)
            {
                bool isValid = true;
                foreach(char letter in word)
                {
                    if (!lettersContained.Contains(letter))
                    {
                        isValid = false;
                    }
                }

                if (isValid == true)
                    wordsToPrint.Add(word);
            }

            Console.WriteLine($"Words found: {wordsToPrint.Count}");

            foreach(var word in wordsToPrint)
            {
                Console.WriteLine(word);
            }
        }
    }
}
