using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string continent = input[0];

                if (!dic.ContainsKey(continent))
                {
                    dic.Add(continent, new Dictionary<string, List<string>>());
                }

                string country = input[1];
                string city = input[2];

                if (!dic[continent].ContainsKey(country))
                {
                    dic[continent].Add(country, new List<string>());
                }

                dic[continent][country].Add(city);
            }

            foreach(var continent in dic)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach(var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
