using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> calculator = new Stack<string>(input);

            while(calculator.Count > 1)
            {
                int num1 = int.Parse(calculator.Pop());
                string action = calculator.Pop();
                int num2 = int.Parse(calculator.Pop());

                switch (action)
                {
                    case "+":
                        calculator.Push((num1 + num2).ToString());
                        break;
                    case "-":
                        calculator.Push((num1 - num2).ToString());
                        break;
                }
            }

            Console.WriteLine(calculator.Pop());
        }
    }
}
