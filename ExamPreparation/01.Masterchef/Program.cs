using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numberOfIngridiants = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Dictionary<string, int> dishes = new Dictionary<string, int>()
            {
                { "Dipping sauce", 0 },
                { "Green salad", 0 },
                { "Chocolate cake", 0 },
                { "Lobster", 0 }
            }; 
            
            while(numberOfIngridiants.Count > 0 && freshness.Count > 0)
            {
                int ingridinetValue = numberOfIngridiants.Dequeue();
                int ingridientFreshness = freshness.Pop();

                if (ingridinetValue == 0)
                    ingridinetValue = numberOfIngridiants.Dequeue();

                if (ingridientFreshness == 0)
                    ingridientFreshness = freshness.Pop();

                int dishValue = ingridinetValue * ingridientFreshness;

                if(dishValue == 150)
                {
                    dishes["Dipping sauce"]++;
                }
                else if(dishValue == 250)
                {
                    dishes["Green salad"]++;
                }
                else if (dishValue == 300)
                {
                    dishes["Chocolate cake"]++;
                }
                else if (dishValue == 400)
                {
                    dishes["Lobster"]++;
                }
                else
                {
                    numberOfIngridiants.Enqueue(ingridinetValue + 5);
                }
            }

            if (dishes.Any(d => d.Value == 0))
                Console.WriteLine("You were voted off. Better luck next year.");
            else
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");

            if (numberOfIngridiants.Count != 0)
                Console.WriteLine($"Ingredients left: {numberOfIngridiants.Sum()}");

            foreach(var dish in dishes.Where(d => d.Value != 0).OrderBy(d => d.Key))
            {
                Console.WriteLine($"# {dish.Key} --> {dish.Value}");
            }
        }
    }
}
