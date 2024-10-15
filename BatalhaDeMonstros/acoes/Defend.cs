public class Defend : IAction
{
    public void Execute(Monster attacker, Monster target)
    {
        Console.WriteLine($"{attacker.Name} se defende!");
        attacker.Defense += 5; 
    }
}
