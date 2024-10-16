public class Zombie : Monster
{
    public Zombie() : base("Zombie", 100, 15) { }

    public override void UseSpecialAbility(Monster target) // Sobrescrevendo o método
    {
        Console.WriteLine($"{Name} infecta {target.Name}, causando 10 de dano!");
        target.TakeDamage(10); // Aplica dano ao alvo
    }
}