using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BakeryShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> bakery = new Dictionary<string, int>();
            Queue<double> water = new Queue<double>(Console.ReadLine().Split().Select(double.Parse));
            Stack<double> flour = new Stack<double>(Console.ReadLine().Split().Select(double.Parse));

            while(water.Count > 0 && flour.Count > 0)
            {
                double currentWater = water.Peek();
                double currentFlour = flour.Peek();
                double productsSum = currentFlour + currentWater;

                if(currentWater == currentFlour)
                {
                    if (!bakery.ContainsKey("Croissant"))
                    {
                        bakery.Add("Croissant", 0);
                    }

                    bakery["Croissant"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if(currentWater *100 / productsSum == 40)
                {
                    if (!bakery.ContainsKey("Muffin"))
                    {
                        bakery.Add("Muffin", 0);
                    }

                    bakery["Muffin"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (currentWater == productsSum * 0.3 && currentFlour == productsSum * 0.7)
                {
                    if (!bakery.ContainsKey("Baguette"))
                    {
                        bakery.Add("Baguette", 0);
                    }

                    bakery["Baguette"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else if (currentWater == productsSum * 0.2 && currentFlour == productsSum * 0.8)
                {
                    if (!bakery.ContainsKey("Bagel"))
                    {
                        bakery.Add("Bagel", 0);
                    }

                    bakery["Bagel"]++;
                    water.Dequeue();
                    flour.Pop();
                }
                else
                {
                    if (!bakery.ContainsKey("Croissant"))
                    {
                        bakery.Add("Croissant", 0);
                    }

                    bakery["Croissant"]++;
                    water.Dequeue();
                    flour.Pop();
                    flour.Push(currentFlour - currentWater);
                }
            }

            foreach (var product in bakery.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            if(water.Count == 0)
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", water)}");
            }

            if(flour.Count == 0)
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flour)}");
            }
        }
    }
}
