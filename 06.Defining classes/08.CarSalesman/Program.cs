using System;
using System.Collections.Generic;

namespace _08.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesOfEngines = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for(int i = 0; i < linesOfEngines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                Engine newEngine = new Engine();
                if(input.Length == 2)
                {
                    newEngine = new Engine(model, power);
                }
                else if (input.Length == 3)
                {
                    string thirdParam = input[2]; 
                    if (int.TryParse(thirdParam, out int displacement))
                    {
                        newEngine = new Engine(model, power, displacement);
                    }

                    else
                    {
                        string efficiency = input[2];
                        newEngine = new Engine(model, power, efficiency);
                    }
                }
                else if(input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];
                    newEngine = new Engine(model, power, displacement, efficiency);
                }

                engines.Add(model, newEngine);
            }

            int linesOfCars = int.Parse(Console.ReadLine());

            for(int i = 0; i < linesOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engineModel = input[1];
                Engine engine = engines[engineModel];
                Car car = new Car();

                if (input.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if(input.Length == 3)
                {
                    string atribute = input[2];
                    if (int.TryParse(atribute, out _))
                    {
                        car = new Car(model, engine, int.Parse(atribute));
                    }
                    else
                    {
                        car = new Car(model, engine, atribute);
                    }
                }
                else if (input.Length == 4)
                {
                    int weight = int.Parse(input[2]);
                    string color = input[3];
                    car = new Car(model, engine, weight, color);
                }
                cars.Add(car);
            }

            foreach(var can in cars)
            {
                Console.WriteLine(can.ToString());
            }
        }
    }
}
