using E04WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        private const double defaultWeightIncrease = 0.40;
        private readonly List<IFood> foodPreferances = new List<IFood>
        {
            new Meat(0),
        };
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override double DefaultWeightIncrease => defaultWeightIncrease;

        public override List<IFood> FoodPreferances => foodPreferances;

        public override string AskForFood()
        {
            return "Woof!";
        }
    }
}
