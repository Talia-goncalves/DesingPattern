public class Dragao : Monster
{
    public Dragao()
    {
        Name = "Dragão";
        Attack = 30;
        Defense = 20;
        Health = 100;
    }

    public override void UseSpecialAbility(Monster target)
    {
        Console.WriteLine($"{Name} lança uma chama em {target.Name}!");
        target.Health -= Attack * 2; 
    }
}
