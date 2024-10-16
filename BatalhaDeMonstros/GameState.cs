public class GameState
{
    public Player Player { get; private set; }
    public Monster EnemyMonster { get; private set; }

    public GameState(Player player, Monster enemyMonster)
    {
        Player = player ?? throw new ArgumentNullException(nameof(player));
        EnemyMonster = enemyMonster ?? throw new ArgumentNullException(nameof(enemyMonster));
    }
}
