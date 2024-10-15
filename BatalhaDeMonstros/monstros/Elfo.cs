public class Elfo : Monster
{
    public Elfo() : base("Elfo", 150, 30, 10) { }

    public override void UseSpecialAbility(Monster target)
    {
        int damage = 50; 
        Console.WriteLine($"{Name} usa suas flechas que atingem múltiplos alvos e cega seu inimigo {target.Name}!");
        target.TakeDamage(damage);
    }
}
