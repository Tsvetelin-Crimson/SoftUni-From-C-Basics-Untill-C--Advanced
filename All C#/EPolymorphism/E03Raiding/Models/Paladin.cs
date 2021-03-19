namespace E03Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int DefaultPower = 100;

        public Paladin(string name) 
            : base(name)
        {
        }

        public override int Power => DefaultPower;

        public override string ClassAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {this.Power}";
        }
    }
}
