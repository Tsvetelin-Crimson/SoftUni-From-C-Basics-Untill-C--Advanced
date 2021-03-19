using E03Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace E03Raiding.Factories
{
    public class HeroFactory : IHeroFactory
    {
        public IHero CreateHero(string heroType, string heroName)
        {
            IHero hero = null;
            if (heroType == nameof(Druid))
            {
                hero = new Druid(heroName);
            }
            if (heroType == nameof(Paladin))
            {
                hero = new Paladin(heroName);
            }
            if (heroType == nameof(Rogue))
            {
                hero = new Rogue(heroName);
            }
            if (heroType == nameof(Warrior))
            {
                hero = new Warrior(heroName);
            }
            else
            {
                return hero;
            }
            return hero;
        }
    }
}
