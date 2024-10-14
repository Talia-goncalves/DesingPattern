public class AttackAction : IAction
{
    public void Execute(Monster attacker, Monster defender)
    {
        int damage = attacker.Attack - defender.Defense;
        defender.Health -= Math.Max(damage, 0);
        Console.WriteLine($"{attacker.Name} attacks {defender.Name}, dealing {damage} damage.");
    }
}