public class SpecialAbilityAction : IActionStrategy
{
    public void Execute(Monster attacker, Monster target)
    {
        attacker.UseSpecialAbility(target);
    }
}
