[Serializable]
public class GameMemento
{
    public GameState State { get; }

    public GameMemento(GameState state)
    {
        State = state;
    }
}
