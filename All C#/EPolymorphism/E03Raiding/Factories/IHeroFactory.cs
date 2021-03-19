using E03Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace E03Raiding.Factories
{
    public interface IHeroFactory
    {
        IHero CreateHero(string heroType, string heroName);
    }
}
