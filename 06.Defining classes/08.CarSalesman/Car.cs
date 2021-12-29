using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public Car()
        {

        }
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color) : this (model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {Engine.Model}:");
            sb.AppendLine($"    Power: {Engine.Power}");

            if(Engine.Displacement != null)
            {
                sb.AppendLine($"    Displacement: {Engine.Displacement}");
            }
            else
            {
                sb.AppendLine($"    Displacement: n/a");
            }

            if(Engine.Efficiency != null)
            {
                sb.AppendLine($"    Efficiency: {Engine.Efficiency}");
            }
            else
            {
                sb.AppendLine($"    Efficiency: n/a");
            }

            if (this.Weight != null)
            {
                sb.AppendLine($"  Weight: {this.Weight}");
            }
            else
            {
                sb.AppendLine($"  Weight: n/a");
            }

            if (this.Color != null)
            {
                sb.AppendLine($"  Color: {this.Color}");
            }
            else
            {
                sb.AppendLine($"  Color: n/a");
            }
            return sb.ToString().Trim();
        }
    }
}
