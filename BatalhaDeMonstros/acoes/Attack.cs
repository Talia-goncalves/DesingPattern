public class Attack : IAction
{
    public void Execute(Monster attacker, Monster target)
    {
        Console.WriteLine($"{attacker.Name} ataca {target.Name}!");
        target.Health -= attacker.Attack;
    }
}
