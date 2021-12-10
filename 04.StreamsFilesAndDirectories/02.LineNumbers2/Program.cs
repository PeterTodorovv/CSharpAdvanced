using System;
using System.IO;

namespace _02.LineNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("../../../text.txt");

            File.WriteAllLines("../../../", lines);

        }
    }
}
