using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Scheduling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int taskValue = int.Parse(Console.ReadLine());

            while (true)
            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();
                if(currentTask == taskValue)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {currentTask}");
                    break;
                }
                else if(currentThread >= currentTask)
                {
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if(currentThread < currentTask)
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine(String.Join(" ", threads));
        }
    }
}
