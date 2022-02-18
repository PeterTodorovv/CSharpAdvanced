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

        public string Name { get; set; }
        public string Brand { get; set; }
        public int Range { get; set; }
        public bool Availabe { get; set; }

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
