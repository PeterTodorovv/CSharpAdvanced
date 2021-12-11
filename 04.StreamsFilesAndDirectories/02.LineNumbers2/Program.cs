using System;
using System.IO;

namespace _02.LineNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("../../../input.txt");
            string[] newLines = new string[lines.Length];
            int count = 1;

            foreach(var line in lines)
            {
                string newLine = $"Line {count}: {line} ({CountLetters(line)})({CountPunctuatuin(line)})";
                newLines[count-1] = newLine;
                count++;
            }
            File.WriteAllLines("../../../output.txt", newLines);

        }

        public static int CountLetters(string line)
        {
            int letters = 0;

            foreach(var chr in line)
            {
                if (char.IsLetter(chr))
                    letters++;
            }

            return letters;
        }

        public static int CountPunctuatuin(string line)
        {
            int ponctuation = 0;

            foreach(var chr in line)
            {
                if (char.IsPunctuation(chr))
                {
                    ponctuation++;
                }
            }

            return ponctuation;
        } 
    }
}
