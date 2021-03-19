using E07MilitaryElite.Interfaces;
using System;

namespace E07MilitaryElite.Models
{
    class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumer = codeNumber;
        }

        public int CodeNumer { get; private set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Code Number: {this.CodeNumer}";
        }
    }
}
