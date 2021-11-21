using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nToEnque = input[0];
            int sToDeque = input[1];
            int x = input[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for(int i = 0; i < nToEnque; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < sToDeque; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count > 0)
            {

                int smallest = int.MaxValue;
                while (queue.Count > 0)
                {
                    int n = queue.Dequeue();
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
