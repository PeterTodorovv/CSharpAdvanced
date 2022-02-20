using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fish;
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            fish = new List<Fish>();
        }

        public string Material { get; set; }
        public int Capacity { get; set; }
        public int Count => fish.Count;
        public IReadOnlyCollection<Fish> Fish => fish;

        public string AddFish(Fish fish)
        {
            if(fish.Length <= 0 && fish.Weight <= 0 && string.IsNullOrWhiteSpace(fish.FishType))
            {
                return "Invalid fish.";
            }
            else if(this.fish.Count == Capacity)
            {
                return "Fishing net is full.";
            }

            this.fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            Fish newFish = fish.FirstOrDefault(f => f.Weight == weight);
            return fish.Remove(newFish);
        }

        public Fish GetFish(string fishType)
        {
            return fish.FirstOrDefault(f => f.FishType == fishType);
        }

        public Fish GetBiggestFish()
        {
            return fish.OrderByDescending(f => f.Length).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder txt = new StringBuilder();
            txt.AppendLine($"Into the {Material}:");

            foreach(var fish in fish.OrderByDescending(f => f.Length))
            {
                txt.AppendLine(fish.ToString().TrimEnd());
            }

            return txt.ToString().TrimEnd();
        }
    }
}
