[Serializable]
public class GameMemento
{
    public int PlayerScore { get; set; }
    public int EnemyScore { get; set; }

    public GameMemento(int playerScore, int enemyScore)
    {
        PlayerScore = playerScore;
        EnemyScore = enemyScore;
    }
}
