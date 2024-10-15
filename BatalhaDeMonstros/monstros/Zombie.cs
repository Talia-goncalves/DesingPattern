public class Zumbi : Monster
{
    public Zumbi()
    {
        Name = "Zumbi";
        Attack = 20;
        Defense = 15;
        Health = 80;
    }

    public override void UseSpecialAbility(Monster target)
    {
        Console.WriteLine($"{Name} se regenera!");
        Health += 10; 
    }
}
