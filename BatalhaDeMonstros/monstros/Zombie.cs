public class Zombie : Monster
{
    public Zombie() : base("Zombie")
    {
        Name = "Zombie";
        Health = 80;
        Attack = 30;
        Defense = 15;
    }

    public override void SpecialMove()
    {
        Console.WriteLine($"{Name} uses Regeneration! Heals 20 health.");
    }
}
