using System;
using System.Collections.Generic;
using System.Linq;

namespace _2StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
             Stack<int> numbers= new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            string input = Console.ReadLine().ToLower();

            while(input != "end")
            {
                string[] splittedInput = input.Split();
                string command = splittedInput[0].ToLower();

                switch (command)
                {
                    case "add":
                        int num1 = int.Parse(splittedInput[1]);
                        int num2 = int.Parse(splittedInput[2]);

                        numbers.Push(num1);
                        numbers.Push(num2);
                        break;
                    case "remove":
                        int numbersToRemove = int.Parse(splittedInput[1]);
                        if(numbersToRemove > numbers.Count)
                        {
                            break;
                        }

                        for(int i = 1; i <= numbersToRemove; i++)
                        {
                            numbers.Pop();
                        }
                        break;
                }

                input = Console.ReadLine().ToLower();
            }

            int sum = 0;
            while(numbers.Count() > 0)
            {
                sum += numbers.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
