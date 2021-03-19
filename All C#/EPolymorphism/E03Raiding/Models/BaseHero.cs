namespace E03Raiding.Models
{
    public abstract class BaseHero : IHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public abstract int Power { get; }

        public abstract string ClassAbility();
        
    }
}
