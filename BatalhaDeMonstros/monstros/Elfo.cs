public class Elfo : Monster
{
    public Elfo() : base("Elfo", 80, 20) { }

    public override void UseSpecialAbility(Monster target) // Sobrescrevendo o método
    {
        Console.WriteLine($"{Name} dispara uma flecha mágica em {target.Name}, causando 15 de dano!");
        target.TakeDamage(15); // Aplica dano ao alvo
    }
}