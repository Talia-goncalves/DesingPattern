public class Phoenix : Monster
{
    public Phoenix()
    {
        Name = "Phoenix";
        Health = 90;
        Attack = 30;
        Defense = 15;
    }

    public override void SpecialMove()
    {
        Console.WriteLine($"{Name} uses Rebirth! Restores to full health.");
    }
}