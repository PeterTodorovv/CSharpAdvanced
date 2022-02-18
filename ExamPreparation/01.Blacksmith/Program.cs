using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Blacksmith
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> swords = new Dictionary<string, int>();
            int Gladius = 70;
            int Shamshir = 80;
            int Katana = 90;
            int Sabre = 110;
            int Broadsword = 150;
            Queue<int> steel = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> carbon = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

            while(steel.Count > 0 && carbon.Count > 0)
            {
                int currentSteel = steel.Peek();
                int currentCarbon = carbon.Peek();
                int totalMetal = currentCarbon + currentSteel;

                if(totalMetal == Gladius)
                {
                    if (!swords.ContainsKey("Gladius"))
                    {
                        swords.Add("Gladius", 0);
                    }

                    swords["Gladius"] += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if(totalMetal == Shamshir)
                {
                    if (!swords.ContainsKey("Shamshir"))
                    {
                        swords.Add("Shamshir", 0);
                    }

                    swords["Shamshir"] += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if(totalMetal == Katana)
                {
                    if (!swords.ContainsKey("Katana"))
                    {
                        swords.Add("Katana", 0);
                    }

                    swords["Katana"] += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (totalMetal == Sabre)
                {
                    if (!swords.ContainsKey("Sabre"))
                    {
                        swords.Add("Sabre", 0);
                    }

                    swords["Sabre"] += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else if (totalMetal == Broadsword)
                {
                    if (!swords.ContainsKey("Broadsword"))
                    {
                        swords.Add("Broadsword", 0);
                    }

                    swords["Broadsword"] += 1;
                    steel.Dequeue();
                    carbon.Pop();
                }
                else
                {
                    steel.Dequeue();
                    carbon.Pop();
                    carbon.Push(currentCarbon + 5);
                }
            }

            if(swords.Count == 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            else
            {
                Console.WriteLine($"You have forged {swords.Values.Sum()} swords.");
            }

            if(steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }

            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }

            foreach(var sword in swords.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{sword.Key}: {sword.Value}");
            }
        }
    }
}
