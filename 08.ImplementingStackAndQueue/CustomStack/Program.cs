using System;

namespace CustomStack
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();

            stack.Push(1);
            stack.Push(2);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
