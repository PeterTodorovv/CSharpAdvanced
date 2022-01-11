using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> people = new SortedSet<Person>();
            HashSet<Person> people2 = new HashSet<Person>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person newPerson = new Person(name, age);

                    people.Add(newPerson);
                    people2.Add(newPerson);
            }

            Console.WriteLine(people.Count);
            Console.WriteLine(people2.Count);
        }
    }
}
