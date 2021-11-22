using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> racks = new Stack<int>();
            racks.Push(0);

            while(clothes.Count > 0)
            {
                int clothe = clothes.Pop();
                int rackCapacity = racks.Peek();
                if(rackCapacity + clothe <= capacity)
                {
                    racks.Push(racks.Pop() + clothe);
                }
                else
                {
                    racks.Push(clothe);
                }
            }

            Console.WriteLine(racks.Count);
        }
    }
}
