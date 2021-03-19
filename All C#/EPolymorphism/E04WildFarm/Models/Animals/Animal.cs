using E04WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace E04WildFarm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        public abstract double DefaultWeightIncrease { get;}
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract List<IFood> FoodPreferances { get; }

        public abstract string AskForFood();

        public virtual bool EatFood(IFood food)
        {
            bool hasEaten = true;
            if (FoodPreferances.FirstOrDefault(k => k.GetType().Name == food.GetType().Name) == null)
            {
                return hasEaten = false;
            }

            Weight += food.Quantity * DefaultWeightIncrease;
            FoodEaten += food.Quantity;
            return hasEaten;
        }

        
    }
}
