using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Tire[] tires = new Tire[4];
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                int j = 5;

                for(int t = 0; t < 4; t++)
                {
                    double tirePressure = double.Parse(input[j]);
                    int tireAge = int.Parse(input[j + 1]);
                    j += 2;
                    tires[t] = new Tire(tireAge, tirePressure);
                }

                cars.Add(new Car(model, new Engine(engineSpeed, enginePower), new Cargo(cargoType, cargoWeight), tires));
            }

            string command = Console.ReadLine();

            if(command == "fragile")
            {
                foreach(var car in cars.Where(c => c.Tires.Any(t => t.Pressure < 1) && c.Cargo.Type == "fragile"))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if(command == "flammable")
            {
                foreach(var car in cars.Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
