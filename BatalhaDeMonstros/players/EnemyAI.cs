using System;

public class EnemyAI
{
    private Random _random = new Random();

    public void TakeTurn(Monster enemy, Monster playerMonster)
    {
        int action = _random.Next(1, 4);
        IActionStrategy strategy = action switch
        {
            1 => new AttackAction(),
            2 => new DefendAction(),
            3 => new SpecialAbilityAction(),
            _ => throw new ArgumentOutOfRangeException()
        };

        strategy.Execute(enemy, playerMonster);
    }
}
