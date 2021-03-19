using System;
using System.Collections.Generic;

namespace E04PizzaCalories
{
    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;
        private const double BaseCaloriesPerGram = 2;
        private readonly Dictionary<string, double> Types = new Dictionary<string, double>
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9}
        };

        private double weight;
        private string type;

        public Topping(string type, double weight)
        {
            this.Type = type;
            this.Weight = weight;
            
        }

        public double TotalCaloreis => BaseCaloriesPerGram * this.Weight * Types[this.Type.ToLower()]; 
        public string Type
        {
            get { return type; }
            private set 
            {
                if (!Types.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                type = value; 
            }
        }
        public double Weight
        {
            get { return weight; }
            private set 
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [{MinWeight}..{MaxWeight}].");
                }
                weight = value;
            }
        }
    }
}
