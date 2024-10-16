public class Player
{
    public Monster Monster { get; private set; }

    public Player(Monster monster)
    {
        Monster = monster;
    }
}
