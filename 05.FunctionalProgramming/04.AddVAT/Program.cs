using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            Action<double[]> addVAT = AddVAT;
            addVAT(prices);
        }

        public static void AddVAT(double[] prices)
        {
            foreach(var price in prices)
            {
                Console.WriteLine($"{(price + price*0.2):f2}");
            }
        }
    }
}
