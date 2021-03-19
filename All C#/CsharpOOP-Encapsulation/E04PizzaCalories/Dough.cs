using System;
using System.Collections.Generic;

namespace E04PizzaCalories
{
    public class Dough
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        private const double BaseCaloriesPerGram = 2;
        private readonly Dictionary<string, double> FlourTypes = new Dictionary<string, double>
        {
            {"white", 1.5},
            {"wholegrain", 1.0}
        };
        private readonly Dictionary<string, double> BakingTechniques = new Dictionary<string, double>
        {
            {"crispy", 0.9},
            {"chewy", 1.1},
            {"homemade", 1.0}
        };

        private string flourType;
        private string bakingTechnique;
        private double weight;
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }


        public double TotalCalories => (BaseCaloriesPerGram * Weight) * FlourTypes[FlourType.ToLower()] * BakingTechniques[BakingTechnique.ToLower()];
        public string FlourType
        {
            get { return flourType; }
            private set 
            {
                if (!FlourTypes.ContainsKey(value.ToLower())) 
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value; 
            }
        }
        public string BakingTechnique
        {
            private get { return bakingTechnique; }
            set
            {
                if (!BakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value; 
            } 
        }
        public double Weight
        {
            private get { return weight; }
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }
                weight = value; 
            }
        }

    }
}
