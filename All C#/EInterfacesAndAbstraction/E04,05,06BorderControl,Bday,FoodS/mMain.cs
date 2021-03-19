using E04_05_06BorderControl_Bday_FoodS.Interfaces;
using E04_05_06BorderControl_Bday_FoodS.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E04_05_06BorderControl_Bday_FoodS
{
    class mMain
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();
            List<Rebel> rebels = new List<Rebel>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                switch (tokens.Length)
                {
                    case 4:
                        string id = tokens[2];
                        string birthdate = tokens[3];
                        Citizen citizen = new Citizen(name, age, id, birthdate);
                        citizens.Add(citizen);
                        break;
                    case 3:
                        string group = tokens[2];
                        Rebel rebel = new Rebel(name, age, group);
                        rebels.Add(rebel);
                        break;
                    default:
                        break;
                }

            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (citizens.FirstOrDefault(k => k.Name == input) != null)
                {
                    citizens.FirstOrDefault(k => k.Name == input).BuyFood();
                }
                else if (rebels.FirstOrDefault(k => k.Name == input) != null)
                {
                    rebels.FirstOrDefault(k => k.Name == input).BuyFood();
                }
            }
            int food = 0;
            foreach (Citizen being in citizens)
            {
                food += being.Food;
            }
            foreach (Rebel being in rebels)
            {
                food += being.Food;
            }
            Console.WriteLine(food);
        }
    }
}
