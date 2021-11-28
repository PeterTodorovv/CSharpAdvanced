using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> values = new Dictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach(var number in input)
            {
                if (!values.ContainsKey(number))
                {
                    values.Add(number, 0);
                }

                values[number]++;
            }

            foreach(var element in values)
            {
                Console.WriteLine($"{element.Key} - {element.Value} times");
            }
        }
    }
}
