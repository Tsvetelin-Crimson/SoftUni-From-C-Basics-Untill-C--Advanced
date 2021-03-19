using E04WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm.Models.Animals
{
    public interface IAnimal
    {
        List<IFood> FoodPreferances { get; }
        string Name { get; }

        double Weight { get; }

        int FoodEaten { get; }

        string AskForFood();

        bool EatFood(IFood food);
    }
}
