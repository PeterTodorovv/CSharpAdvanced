using System;

namespace _08.ImplementingStackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            list.RemoveAt(0);
            /*
             * 2, 3, 4, 5, 6, 7
             * 2, 3, 4, 5, 6
             */
            list.RemoveAt(5);

            list.Swap(0, 1);
            /*
             * 3 2 4 5 6
             * 3 2 69 4 5 6
             */
            list.Insert(1, 69);
            list.Insert(0, 1);
            Console.WriteLine(list.Contains(3));
            Console.WriteLine(list.Contains(40));

            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
