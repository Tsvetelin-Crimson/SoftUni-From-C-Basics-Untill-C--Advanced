using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm.Models.Animals
{
    public abstract class Feline : Mammal, IFeline
    {
        protected Feline(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{base.Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
