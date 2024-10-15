public class Robot : Monster
{
    public Robot() : base("Robot")
    {
        Name = "Robot";
        Health = 100;
        Attack = 35;
        Defense = 20;
    }

    public override void SpecialMove()
    {
        Console.WriteLine($"{Name} uses Laser Beam! Deals 60 damage.");
    }
}