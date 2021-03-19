using E04WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace E04WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        private const double defaultWeightIncrease = 0.25;
        private readonly List<IFood> foodPreferances = new List<IFood>
        {
            new Meat(0),
        };
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double DefaultWeightIncrease => defaultWeightIncrease;

        public override List<IFood> FoodPreferances => foodPreferances;

        public override string AskForFood()
        {
            return "Hoot Hoot";
        }
    }
}
