using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        Dictionary<string, Car> parking = new Dictionary<string, Car>();
        public int Capacity { get; set; } 
        public int Count { get { return parking.Count; } }

        public Parking(int capacity)
        {
            this.Capacity = capacity;
        }

        public string AddCar(Car car)
        {
            if (parking.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if(parking.Count < Capacity)
            {
                parking.Add(car.RegistrationNumber, car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
            else
            {
                return "Parking is full!";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (parking.ContainsKey(registrationNumber))
            {
                parking.Remove(registrationNumber);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return parking[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach(var numeber in registrationNumbers)
            {
                parking.Remove(numeber);
            }
        }
    }
}
