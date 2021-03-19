using E03Raiding.Factories;
using E03Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace E03Raiding.Core
{
    class Engine : IEngine
    {
        private IHeroFactory heroFactory = new HeroFactory();
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            List<IHero> heroes = new List<IHero>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                IHero currHero = heroFactory.CreateHero(type, name);

                if (currHero != null)
                {
                    heroes.Add(currHero);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            int result = 0;

            foreach (IHero hero in heroes)
            {
                Console.WriteLine(hero.ClassAbility());
                result += hero.Power;
            }

            if (result >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
