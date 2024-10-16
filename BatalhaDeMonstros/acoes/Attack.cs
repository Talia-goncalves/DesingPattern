public class AttackAction : IActionStrategy
{
    public void Execute(Monster attacker, Monster target)
    {
        target.TakeDamage(attacker.Attack);
    }
}
