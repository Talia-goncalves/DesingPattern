public class SpecialAbility : IAction
{
    public void Execute(Monster attacker, Monster target)
    {
        attacker.UseSpecialAbility(target);
    }
}
