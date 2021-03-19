using E04WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        private const double defaultWeightIncrease = 0.35;
        private readonly List<IFood> foodPreferances = new List<IFood>
        {
            new Meat(0),
            new Fruit(0),
            new Seeds(0),
            new Vegetable(0),
        };
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override double DefaultWeightIncrease => defaultWeightIncrease;

        public override List<IFood> FoodPreferances => foodPreferances;

        public override string AskForFood()
        {
            return "Cluck";
        }
    }
}
