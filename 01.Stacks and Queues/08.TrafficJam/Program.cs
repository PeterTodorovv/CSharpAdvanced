using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string input = Console.ReadLine();
            int carsPassed = 0;

            while(input != "end")
            {
                if(input == "green")
                {
                    int carsToPass = n;
                    if(cars.Count < n)
                    {
                        carsToPass = cars.Count;
                    }
                    for(int i = 1; i <= carsToPass; i++)
                    {
                       Console.WriteLine($"{cars.Dequeue()} passed!");
                       carsPassed++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
