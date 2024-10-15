public class Zombie : Monster
{
    public Zombie() : base("Zumbi", 120, 25, 5) { }

    public override void UseSpecialAbility(Monster target)
    {
        int healAmount = 20; // Cura do Zumbi
        Health += healAmount;
        Console.WriteLine($"{Name} usa Cura e recupera {healAmount} de vida!");
    }
}
