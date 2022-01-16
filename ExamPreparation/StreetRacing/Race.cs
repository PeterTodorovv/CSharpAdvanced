using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
{
    class Race
    {
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public int Count { get { return Participants.Count; } }
        private Dictionary<string, Car> Participants = new Dictionary<string, Car>();

        public void Add(Car car)
        {
            if(!Participants.Any(c => c.Key == car.LicensePlate) &&  Capacity>= Participants.Count + 1 && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car.LicensePlate, car);
            }
        }

        public bool Remove(string licensePlate)
        {
            return Participants.Remove(licensePlate);
        }

        public Car FindParticipant(string licensePlate)
        {
            foreach(var car in Participants)
            {
                if (car.Key == licensePlate)
                    return car.Value;
            }

            return null;
        }

        public Car GetMostPowerfulCar()
        {
            if (Participants.Count == 0)
                return null;
            else
            {
                int mostHorsePower = int.MinValue;
                Car fastest = null;
                foreach(var car in Participants.Values)
                {
                    if(car.HorsePower < mostHorsePower)
                    {
                        mostHorsePower = car.HorsePower;
                        fastest = car;
                    }
                }

                return fastest;
            }
        }

        public string Report()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");

           foreach(var car in Participants.Values)
            {
                text.AppendLine(car.ToString());
            }

            return text.ToString();
        }
    }
}
