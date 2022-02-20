using System.Text;

namespace Drones
{
    public class Drone
    {
        public Drone(string name, string brand, int range)
        {
            Name = name;
            Brand = brand;
            Range = range;
            Availabe = true;
        }

        public string Name;
        public string Brand;
        public int Range;
        public bool Availabe;

        public override string ToString()
        {
            StringBuilder txt = new StringBuilder();
            txt.AppendLine($"Drone: {Name}");
            txt.AppendLine($"Manufactured by: {Brand}");
            txt.AppendLine($"Range: {Range}");
            txt.AppendLine($"Range: {Range} kilometers");
            return txt.ToString().Trim();
        }
    }
}
