public class Golem : Monster
{
    public Golem()
    {
        Name = "Golem";
        Health = 150;
        Attack = 25;
        Defense = 35;
    }

    public override void SpecialMove()
    {
        Console.WriteLine($"{Name} uses Earthquake! Stuns the enemy for 1 turn.");
    }
}