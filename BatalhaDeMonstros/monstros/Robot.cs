public class Robot : Monster
{
    public Robot() : base("Robô", 100, 20, 15) { }

    public override void UseSpecialAbility(Monster target)
    {
        int damage = 40; // Ataque de Laser
        Console.WriteLine($"{Name} usa Ataque de Laser em {target.Name}!");
        target.TakeDamage(damage);
    }
}
