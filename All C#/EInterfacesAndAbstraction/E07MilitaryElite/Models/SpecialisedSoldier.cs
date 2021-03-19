using E07MilitaryElite.Enums;
using E07MilitaryElite.Interfaces;
using System;

namespace E07MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corp) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corp;
        }

        public Corps Corps { get; private set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }
}
