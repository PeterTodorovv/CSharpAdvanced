using System;

namespace CustomDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>(); 
            list.AddFirst(2);
            Console.WriteLine(string.Join(" ", list.ToArray()));

            list.AddFirst(1);
            Console.WriteLine(string.Join(" ", list.ToArray()));

            list.AddLast(3);
            Console.WriteLine(string.Join(" ", list.ToArray()));

            list.AddLast(4);
            Console.WriteLine(string.Join(" ", list.ToArray()));

            list.RemoveFirst();
            Console.WriteLine(string.Join(" ", list.ToArray()));

            list.RemoveLast();
            Console.WriteLine(string.Join(" ", list.ToArray()));

        }
    }
}
