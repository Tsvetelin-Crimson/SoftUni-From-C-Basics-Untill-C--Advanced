namespace E03Raiding.Models
{
    public interface IHero
    {
        string Name { get; }

        int Power { get; }

        string ClassAbility();
    }
}