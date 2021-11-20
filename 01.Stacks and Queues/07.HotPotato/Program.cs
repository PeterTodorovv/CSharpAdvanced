using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());

            while(queue.Count > 1)
            {
                for(int i = 1; i < n; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine("Removed " + queue.Dequeue());
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
