using System;

namespace CustomQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<int> queue = new CustomQueue<int>();

            queue.Enque(1);
            queue.Enque(2);
            queue.Enque(3);
            queue.Enque(4);
            queue.Enque(5);
            Console.WriteLine(queue.Deque());
            Console.WriteLine(queue.Peek());
            queue.ForEach(Console.WriteLine);
            queue.Clear();
            queue.Deque();
            
            
        }
    }
}
