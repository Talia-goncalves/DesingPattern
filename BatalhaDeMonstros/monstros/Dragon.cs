public class Dragon : Monster
{
    public Dragon() : base("Dragão", 150, 30, 10) { }

    public override void UseSpecialAbility(Monster target)
    {
        int damage = 50; // Fogo do Dragão
        Console.WriteLine($"{Name} usa Fogo do Dragão em {target.Name}!");
        target.TakeDamage(damage);
    }
}
