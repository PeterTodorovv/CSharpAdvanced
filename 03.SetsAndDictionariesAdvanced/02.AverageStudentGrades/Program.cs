﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students.Add(name, new List<decimal>());
                }

                students[name].Add(grade);
            }

            foreach(var student in students)
            {
                decimal average = student.Value.Average();
                Console.Write($"{student.Key} -> ");

                foreach(var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.Write($"(avg: {average:f2})");
                Console.WriteLine();
            }
        }
    }
}
