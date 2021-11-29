using System;
using System.Collections.Generic;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dictionary<string, List<string>>>> vlogers = new Dictionary<string, List<Dictionary<string, List<string>>>>();
            string input = Console.ReadLine();

            while(input != "Statistics")
            {
                string[] splitted = input.Split();
                string name = splitted[0];
                string action = splitted[1];

                switch (action)
                {
                    case "joined ":
                        if (!vlogers.ContainsKey(name))
                        {
                            vlogers.Add(name, new List<Dictionary<string, List<string>>>());
                            vlogers[name].Add("followers", new List<string>());
                        }
                        break;
                    case "followed":
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
