using System;
using System.IO;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader reader = new StreamReader("../../../input.txt"))
            {
                using(StreamWriter writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    int index = 0;

                    while (line != null)
                    { 
                        if (index % 2 == 0)
                        {
                            foreach(char chr in line)
                            {
                                if(chr == '-' || chr == ',' || chr == '.' || chr == '!' || chr == '?')
                                {
                                    line = line.Replace(chr, '@');
                                }
                            }

                            string[] words = line.Split();
                            for(int i = words.Length - 1; i >= 0; i--)
                            {
                                writer.Write(words[i] + " ");
                            }
                            writer.WriteLine();
                        }

                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
