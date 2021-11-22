using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Console.WriteLine(orders.Max());

            while(foodQuantity > 0 && orders.Count > 0)
            {
                int order = orders.Peek();
                if(foodQuantity >= order)
                {
                    foodQuantity -= order;
                    orders.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if(orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
        }
    }
}
