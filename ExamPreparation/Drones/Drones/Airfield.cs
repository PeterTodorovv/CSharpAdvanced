using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            drones = new Dictionary<string, Drone>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public Dictionary<string, Drone> drones;
        public int Count { get { return drones.Count; } }

        public string AddDrone(Drone drone)
        {
            if(Capacity < Count + 1)
            {
                return "Airfield is full.";
            }
            else if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return "Invalid drone.";
            }

            drones.Add(drone.Name, drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            return drones.Remove(name);
        }

        public int RemoveDroneByBrand(string brand)
        {
            int removed = 0;

            foreach(var drone in drones)
            {
                if(drone.Value.Brand == brand)
                {
                    drones.Remove(drone.Key);
                    removed++;
                }
            }

            return removed;
        }

        public Drone FlyDrone(string name)
        {
            if (drones.ContainsKey(name))
            {
                drones[name].Availabe = false;
                return drones[name];
            }
            return null;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> dronesToFly = new List<Drone>();

            foreach(var drone in drones.Values)
            {
                if(drone.Range >= range)
                {
                    dronesToFly.Add(drone);
                    FlyDrone(drone.Name);
                }
            }

            return dronesToFly;
        }

        public string Report()
        {
            StringBuilder txt = new StringBuilder();
            txt.AppendLine($"Drones available at {Name}:");

            foreach(var drone in drones.Values.Where(d => d.Availabe == true))
            {
                txt.AppendLine(drone.ToString().Trim());
            }

            return txt.ToString().Trim();
        }
    }
}
