using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nToPush = input[0];
            int sToPop = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < nToPush; i++)
            {
                int number = numbers[i];
                stack.Push(number);
            }

            for(int i = 1; i <= sToPop; i++)
            {
                stack.Pop();
            }


            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if(stack.Count > 0)
            {

                int smallest = int.MaxValue;
                while (stack.Count > 0)
                {
                    int n = stack.Pop();
                    if (n < smallest) smallest = n;
                }
                Console.Write(smallest);
                
            }
            else
            {
                Console.Write(0);
            }
        }
    }
}
