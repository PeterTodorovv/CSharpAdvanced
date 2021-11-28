using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            string input = Console.ReadLine();

            while(input != "PARTY")
            {
                guests.Add(input);
                input = Console.ReadLine();
            }

            while(input != "END")
            {
                guests.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(guests.Count);

            foreach(var guest in guests)
            {
                if(char.IsDigit(guest[0]))
                    Console.WriteLine(guest);
            }

            foreach (var guest in guests)
            {
                if (!char.IsDigit(guest[0]))
                    Console.WriteLine(guest);
            }
        }
    }
}
