using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm.Models.Animals
{
    public abstract class Bird : Animal, IBird
    {
        public Bird(string name, double weight, double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{base.Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
