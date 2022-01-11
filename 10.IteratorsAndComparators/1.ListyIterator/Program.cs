using System;
using System.Linq;

namespace _1.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] create = Console.ReadLine().Split();

            ListyIterator<string> listy = new ListyIterator<string>();
            listy.Create(create.Skip(1).ToArray());
            string input = Console.ReadLine();

            while(input != "END")
            {
                if (input == "Move")
                    Console.WriteLine(listy.Move());
                else if (input == "Print")
                    listy.Print();
                else if (input == "HasNext")
                    Console.WriteLine(listy.HasNext());
                else if (input == "PrintAll")
                    listy.PrintAll();


                input = Console.ReadLine();
            }
        }
    }
}
