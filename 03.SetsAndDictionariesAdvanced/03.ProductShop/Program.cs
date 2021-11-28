using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dicitinary = new Dictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();

            while(input != "Revision")
            {
                string[] splitted = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string store = splitted[0];
                if (!dicitinary.ContainsKey(store))
                {
                    dicitinary.Add(store, new Dictionary<string, double>());
                }

                string product = splitted[1];
                double price = double.Parse(splitted[2]);
                if (!dicitinary[store].ContainsKey(product))
                {
                    dicitinary[store].Add(product, price);
                }

                input = Console.ReadLine();
            }

            foreach(var store in dicitinary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{store.Key}->");

                foreach(var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
