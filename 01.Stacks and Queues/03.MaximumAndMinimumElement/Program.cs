using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(); 
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                switch (command)
                {
                    case "1":
                        stack.Push(int.Parse(input[1]));
                        break;
                    case "2":
                        if(stack.Count > 0)
                            stack.Pop();
                        break;
                    case "3":
                        if (stack.Count > 0)
                            Console.WriteLine(stack.Max());
                        break;
                    case "4":
                        if (stack.Count > 0)
                            Console.WriteLine(stack.Min());
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
