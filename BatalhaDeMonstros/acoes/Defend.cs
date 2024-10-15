public class DefendAction : IActionStrategy
{
    public void Execute(Monster attacker, Monster target)
    {
        Console.WriteLine($"{attacker.Name} está se defendendo!");
    }
}
