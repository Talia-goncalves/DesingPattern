public class Player
{
    public string Name { get; private set; }
    public int Health { get; set; }
    public int Score { get; set; }
    public Monster Monster { get; private set; }

    // Construtor para aceitar o monstro junto com o nome
    public Player(string name, Monster monster)
    {
        Name = name;
        Health = 100; // Vida inicial do jogador
        Score = 0; // Pontuação inicial do jogador
        Monster = monster;
    }
}
