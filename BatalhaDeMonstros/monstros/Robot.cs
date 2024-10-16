public class Robot : Monster
{
    public Robot() : base("Robô", 120, 25) { }

    public override void UseSpecialAbility(Monster target) // Sobrescrevendo o método
    {
        Console.WriteLine($"{Name} dispara um laser em {target.Name}, causando 20 de dano!");
        target.TakeDamage(20); // Aplica dano ao alvo
    }
}