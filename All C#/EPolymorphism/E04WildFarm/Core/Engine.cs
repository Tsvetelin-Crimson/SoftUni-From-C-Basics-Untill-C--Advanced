using E04WildFarm.Models.Animals;
using E04WildFarm.Models.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace E04WildFarm.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<IAnimal> animals = new List<IAnimal>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalTokens = input.Split();
                string animalType = animalTokens[0];
                string name = animalTokens[1];
                double weight = double.Parse(animalTokens[2]);
                IAnimal currAnimal = null;
                switch (animalType)
                {
                    case nameof(Owl):
                        double wingSize = double.Parse(animalTokens[3]);
                        currAnimal = new Owl(name, weight, wingSize);
                        break;
                    case nameof(Hen):
                        wingSize = double.Parse(animalTokens[3]);
                        currAnimal = new Hen(name, weight, wingSize);
                        break;
                    case nameof(Mouse):
                        string livingRegion = animalTokens[3];
                        currAnimal = new Mouse(name, weight, livingRegion);
                        break;
                    case nameof(Dog):
                        livingRegion = animalTokens[3];
                        currAnimal = new Dog(name, weight, livingRegion);
                        break;
                    case nameof(Cat):
                        livingRegion = animalTokens[3];
                        string breed = animalTokens[4];
                        currAnimal = new Cat(name, weight, livingRegion, breed);
                        break;
                    case nameof(Tiger):
                        livingRegion = animalTokens[3];
                        breed = animalTokens[4];
                        currAnimal = new Tiger(name, weight, livingRegion, breed);
                        break;
                    default:
                        break;
                }
                                
                string[] foodTokens = Console.ReadLine().Split();
                string foodType = foodTokens[0];
                int quantity = int.Parse(foodTokens[1]);
                IFood food = null;
                switch (foodType)
                {
                    case nameof(Meat):
                        food = new Meat(quantity);
                        break;
                    case nameof(Vegetable):
                        food = new Vegetable(quantity);

                        break;
                    case nameof(Seeds):
                        food = new Seeds(quantity);

                        break;
                    case nameof(Fruit):
                        food = new Fruit(quantity);

                        break;
                    default:
                        break;
                }

                Console.WriteLine(currAnimal.AskForFood());
                bool hasEaten = currAnimal.EatFood(food);
                if(!hasEaten)
                {
                    Console.WriteLine($"{animalType} does not eat {foodType}!");
                }
                animals.Add(currAnimal);
            }

            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

        }
    }
}
