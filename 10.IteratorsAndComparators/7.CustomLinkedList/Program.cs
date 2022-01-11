using System;

namespace _7.CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);

            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
