using System;
using System.Collections.Generic;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Tire> tires = new List<Tire>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            while(input[0] != "No more tires")
            {
                tires.Add(new Tire(int.Parse(input[0]), int.Parse(input[1])));
                input = Console.ReadLine().Split();
            }

            input = Console.ReadLine().Split();
            while(input[0] != "Engines done")
            {
                engines.Add(new Engine(int.Parse(input[0]), double.Parse(input[1])));
                input = Console.ReadLine().Split();
            }

            input = Console.ReadLine().Split();
            while (input[0] != "Show special")
            {
                string make = input[0];
                string model = input[1];
                int year = int.Parse(input[2]);
                double fuelQuantity = double.Parse(input[3]);
                double fuelConsumption = double.Parse(input[3]);
                Engine engine = engines[int.Parse(input[4])];

                cars.Add(new Car());
                input = Console.ReadLine().Split();
            }
        }
    }
}
