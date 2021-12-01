using System;
using System.IO;

namespace _05.SliceAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var reader = new StreamReader("../../../input.txt"))
            {
                string text = reader.ReadToEnd();
                int index = 0;
                using(var writer = new StreamWriter("../../../output1.txt"))

                {
                    for(int i = index; i < index + text.Length / 4; i++)
                    {
                        writer.Write(text[i]);
                    }
                    index += text.Length / 4;
                }

                using (var writer = new StreamWriter("../../../output2.txt"))
                {
                    for (int i = index; i < index + text.Length / 4; i++)
                    {
                        writer.Write(text[i]);
                    }
                    index += text.Length / 4;
                }

                using (var writer = new StreamWriter("../../../output3.txt"))
                {
                    for (int i = index; i < index + text.Length / 4; i++)
                    {
                        writer.Write(text[i]);
                    }
                    index += text.Length / 4;
                }

                using (var writer = new StreamWriter("../../../output4.txt"))
                {
                    for (int i = index; i < index + text.Length / 4; i++)
                    {
                        writer.Write(text[i]);
                    }
                    index += text.Length / 4;
                }
            }
        }
    }
}
