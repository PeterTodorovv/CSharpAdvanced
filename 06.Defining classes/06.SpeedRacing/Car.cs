using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public void CheckIfCarCanMove(double amountKM)
        {
            if(FuelAmount >= FuelConsumptionPerKilometer * amountKM)
            {
                TravelledDistance += amountKM;
                FuelAmount -= FuelConsumptionPerKilometer * amountKM;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
