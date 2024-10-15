public class GameState
{
    public int PlayerScore { get; set; }
    public int EnemyScore { get; set; }

    public GameState()
    {
        PlayerScore = 0;
        EnemyScore = 0;
    }
}
