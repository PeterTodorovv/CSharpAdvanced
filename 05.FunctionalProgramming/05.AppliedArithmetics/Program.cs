using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], string, int[]> calculator = Calculator;
            string command = Console.ReadLine();

            while(command != "end")
            {
                numbers = calculator(numbers, command);
                command = Console.ReadLine();
            }


        }

        public static int[] Calculator(int[] numbers, string command)
        {
            if(command == "print")
            {
                Console.WriteLine(string.Join(" ", numbers));
                return numbers;
            }
            int[] numbersToReturn = new int[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                numbersToReturn[i] = Actions(numbers[i], command);
            }
            return numbersToReturn;
        }

        public static int Actions(int number, string action)
        {
            int numberToRetun = 0;
            switch (action)
            {
                case "add":
                    numberToRetun = number + 1; 
                    break;
                case "multiply":
                    numberToRetun = number * 2;
                    break;
                case "subtract":
                    numberToRetun = number - 1;
                    break;
            }
            return numberToRetun;
        }
    }
}
