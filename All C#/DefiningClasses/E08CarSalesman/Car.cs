using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace E08CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = 0;
            this.Color = "n/a";
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.Color = color;
        }
        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;

        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string weight = this.Weight.ToString();
            if (this.Weight == 0)
            {
                weight = "n/a";
            }
            string displacement = this.Engine.Displacement.ToString();
            if (this.Engine.Displacement == 0)
            {
                displacement = "n/a";
            }

            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Model}:" + Environment.NewLine);
            sb.Append($" {this.Engine.Model}:" + Environment.NewLine);
            sb.Append($"  Power: {this.Engine.Power}" + Environment.NewLine);
            sb.Append($"  Displacement: {displacement}" + Environment.NewLine);
            sb.Append($"  Efficiency: {this.Engine.Efficiency}" + Environment.NewLine);
            sb.Append($" Weight: {weight}" + Environment.NewLine);
            sb.Append($" Color: {this.Color}");

            return sb.ToString();
        }
    }
}
