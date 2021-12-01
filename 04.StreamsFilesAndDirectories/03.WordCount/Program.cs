using System;
using System.Collections.Generic;
using System.IO;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsRepeated = new Dictionary<string, int>();

            using(var reader = new StreamReader("../../../words.txt"))
            {
                using(var reader2 = new StreamReader("../../../input.txt"))
                {
                    using (var writer = new StreamWriter("../../../output.txt"))
                    {
                        string[] words = reader.ReadToEnd().Split();
                        foreach(string word in words)
                        {
                            wordsRepeated.Add(word, 0);
                        }

                        var line = reader2.ReadLine();
                        while(line != null)
                        {
                            string[] splttedLine = line.Split();
                            foreach(string element in splttedLine)
                            {
                                if (wordsRepeated.ContainsKey(element.ToLower()))
                                {
                                    wordsRepeated[element.ToLower()]++;
                                }
                            }

                            line = reader2.ReadLine();
                        }

                        foreach(var element in wordsRepeated)
                        {
                            writer.WriteLine($"{element.Key} - {element.Value}");
                        }
                    }
                }
            }
        }
    }
}
