
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int maxPriceSet = 0;
            List<int> sets = new List<int>();

            while(hats.Count > 0 && scarfs.Count > 0)
            {
                int hat = hats.Peek();
                int scarf = scarfs.Peek();

                if(hat > scarf)
                {
                    int set = hat + scarf;
                    sets.Add(set);
                    hats.Pop();
                    scarfs.Dequeue();

                    if (set > maxPriceSet)
                        maxPriceSet = set;
                }
                else if(scarf > hat)
                {
                    hats.Pop();
                }
                else if(scarf == hat)
                {
                    scarfs.Dequeue();
                    hat++;
                    hats.Pop();
                    hats.Push(hat);
                    
                }
            }

            Console.WriteLine($"The most expensive set is: {maxPriceSet}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
