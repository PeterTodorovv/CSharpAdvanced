using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = line[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                string[] clothes = line[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                foreach(var clothe in clothes)
                {
                    if (!wardrobe[color].ContainsKey(clothe))
                    {
                        wardrobe[color].Add(clothe, 0);
                    }

                    wardrobe[color][clothe]++;
                }
            }

            string[] searched = Console.ReadLine().Split();

            foreach(var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                if(color.Key == searched[0])
                {
                    foreach(var clothe in color.Value)
                    {
                        if(clothe.Key == searched[1])
                        {
                            Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                        }
                    }
                }
                else
                {
                    foreach (var clothe in color.Value)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                    }
                }
            }
        }
    }
}
