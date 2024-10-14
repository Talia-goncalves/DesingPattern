public class Dragon : Monster
{
    public Dragon()
    {
        Name = "Dragon";
        Health = 120;
        Attack = 40;
        Defense = 25;
    }

    public override void SpecialMove()
    {
        Console.WriteLine($"{Name} uses Fire Breath! Deals 50 damage.");
    }
}
