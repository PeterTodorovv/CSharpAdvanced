using System;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] borders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string type = Console.ReadLine();
            Action<int[], Predicate<int>, string> filter = (numbers, action, type) => 
            {
                for(int number = numbers[0]; number <= numbers[1]; number++)
                {
                    if(type == "even")
                    {
                        if (action(number))
                            Console.Write(number + " ");
                    }
                    else if(type == "odd")
                    {
                        if (!action(number))
                            Console.Write(number + " ");
                    }
                }
            };

            Predicate<int> isEven = x => x % 2 == 0;


            filter(borders, isEven, type);
        }
    }
}
