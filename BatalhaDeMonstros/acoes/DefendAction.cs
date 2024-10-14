public class DefendAction : IAction
{
    public void Execute(Monster attacker, Monster defender)
    {
        defender.Defense += 10;  // Aumenta temporariamente a defesa
        Console.WriteLine($"{defender.Name} defends and gains 10 defense.");
    }
}