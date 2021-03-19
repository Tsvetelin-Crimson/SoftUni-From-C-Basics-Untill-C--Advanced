namespace E03Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int DefaultPower = 100;

        public Warrior(string name) 
            : base(name)
        {
        }

        public override int Power => DefaultPower;

        public override string ClassAbility()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }
    }
}
