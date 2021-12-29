using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];

                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                if (!cars.ContainsKey(model))
                {
                    cars.Add(model ,new Car(model, fuelAmount, fuelConsumptionFor1km));
                }
            }

            string[] command = Console.ReadLine().Split();

            while(command[0] != "End")
            {
                string carModel = command[1];
                double amountKM = double.Parse(command[2]);
                Car car = cars[carModel];
                car.CheckIfCarCanMove(amountKM);
                command = Console.ReadLine().Split();
            }

            foreach(var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
