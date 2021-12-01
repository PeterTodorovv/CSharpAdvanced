using System;
using System.IO;

namespace _06.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Console.ReadLine();

            string[] files = Directory.GetFiles(directoryPath);
            double sum = 0;

            for(int i = 0; i < files.Length; i++)
            {
                FileInfo info = new FileInfo(files[i]);
                sum += info.Length;
            }

            Console.WriteLine(sum);
        }
    }
}
