using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List <Person> people = new List<Person>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                people.Add(new Person(name, age));
            }

            Console.WriteLine($"{people.OrderByDescending(p => p.Age).First().Name} {people.OrderByDescending(p => p.Age).First().Age}");
            /*foreach(var person in people.Where(a => a.Age > 30).OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
            */
        }
    }
}
