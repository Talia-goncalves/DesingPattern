public class Robo : Monster
{
    public Robo()
    {
        Name = "Robô";
        Attack = 25;
        Defense = 25;
        Health = 90;
    }

    public override void UseSpecialAbility(Monster target)
    {
        Console.WriteLine($"{Name} dispara um laser em {target.Name}!");
        target.Health -= Attack; 
    }
}
