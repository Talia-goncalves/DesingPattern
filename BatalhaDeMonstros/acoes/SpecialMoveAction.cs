public class SpecialMoveAction : IAction
{
    public void Execute(Monster attacker, Monster defender)
    {
        attacker.SpecialMove();
    }
}