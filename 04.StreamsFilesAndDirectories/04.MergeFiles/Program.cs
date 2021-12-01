using System;
using System.IO;

namespace _04.MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var reader1 = new StreamReader("../../../input1.txt"))
            {
                using (var reader2 = new StreamReader("../../../input2.txt"))
                {
                    using(var writer = new StreamWriter("../../../output.txt"))
                    {
                        var line1 = reader1.ReadLine();
                        var line2 = reader2.ReadLine();
                        while(line1 != null)
                        {
                            writer.WriteLine(line1);
                            writer.WriteLine(line2);
                            line1 = reader1.ReadLine();
                            line2 = reader2.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
