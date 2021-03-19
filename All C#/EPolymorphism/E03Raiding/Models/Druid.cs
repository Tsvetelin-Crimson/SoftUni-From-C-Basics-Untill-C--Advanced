namespace E03Raiding.Models
{
    public class Druid : BaseHero
    {
        private const int DefaultPower = 80;
        public Druid(string name) 
            : base(name)
        {
        }

        public override int Power => DefaultPower;

        public override string ClassAbility()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {Power}";
        }
    }
}
