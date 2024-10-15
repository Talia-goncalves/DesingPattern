public class AttackAction : IActionStrategy
{
    public void Execute(Monster attacker, Monster target)
    {
        int damage = attacker.Attack();
        target.TakeDamage(damage);
        Console.WriteLine($"{attacker.Name} atacou {target.Name} e causou {damage} de dano!");
    }
}
