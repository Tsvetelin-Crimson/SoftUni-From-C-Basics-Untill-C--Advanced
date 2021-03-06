using E04WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double defaultWeightIncrease = 1.00;
        private readonly List<IFood> foodPreferances = new List<IFood>
        {
            new Meat(0),
        };
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override double DefaultWeightIncrease => defaultWeightIncrease;

        public override List<IFood> FoodPreferances => foodPreferances;

        public override string AskForFood()
        {
            return "ROAR!!!";
        }
    }
}
