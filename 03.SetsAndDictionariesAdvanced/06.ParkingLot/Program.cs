using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] splitted = input.Split(", ");
                string command = splitted[0];
                string number = splitted[1];

                switch (command)
                {
                    case "IN":
                        cars.Add(number);
                        break;
                    case "OUT":
                        cars.Remove(number);
                        break;
                }

                input = Console.ReadLine();
            }

            if(cars.Count > 0)
            {
                foreach(var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
