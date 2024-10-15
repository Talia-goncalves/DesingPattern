using System;

[Serializable]
public class GameState
{
    public Player Player { get; set; }
    public Monster EnemyMonster { get; set; }
}
