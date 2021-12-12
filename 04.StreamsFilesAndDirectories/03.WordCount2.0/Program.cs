using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach(string word in words)
            {
                wordsCount.Add(word.ToLower(), 0);
            }

            string[] text = File.ReadAllText("../../../text.txt").Split(',', '.', ';', ' ', '-');


            foreach(string word in text)
            {
                if (wordsCount.ContainsKey(word.ToLower()))
                {
                    wordsCount[word.ToLower()]++;
                }
            }

            string[] lines = new string[wordsCount.Count];

            int count = 0;
            foreach(var word in wordsCount.OrderByDescending(v => v.Value))
            {
                lines[count] = $"{word.Key}-{word.Value}";
                count++;
            }

            File.WriteAllLines("../../../actualResult.txt", lines);
        }
    }
}
