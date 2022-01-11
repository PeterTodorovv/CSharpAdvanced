using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            customStack<string> stack = new customStack<string>();
            string[] input = Console.ReadLine().Split();

            while(input[0] != "END")
            {
                if(input[0] == "Push")
                {
                    var elementsToAdd = String.Join("", input.Skip(1)).Split(",");
                    stack.Push(elementsToAdd);
                }
                else if(input[0] == "Pop")
                {
                    stack.Pop();
                }

                input = Console.ReadLine().Split();
            }

            foreach(var elelemnt in stack)
            {
                Console.WriteLine(elelemnt);
            }

            foreach (var elelemnt in stack)
            {
                Console.WriteLine(elelemnt);
            }
        }
    }
}
