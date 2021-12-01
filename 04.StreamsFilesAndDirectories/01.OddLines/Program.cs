using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../first.txt"))
            {
                using (var writer = new StreamWriter("../../../second.txt"))
                {
                    var line = reader.ReadLine();
                    int index = 0;
                    while(line != null)
                    {
                        index++;
                        if(index % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
