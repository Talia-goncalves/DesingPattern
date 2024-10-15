using System;

public class GameManager
{
    // Singleton instance
    private static GameManager _instance = new GameManager();
    public static GameManager Instance
    {
        get
        {
            return _instance;
        }
    }

    // Propriedades dos jogadores
    public Player Player1 { get; private set; }
    public Player Player2 { get; private set; }

    // Exemplo de pontuação global
    public int Score { get; private set; }

    // Construtor privado para evitar instanciamento fora da classe
    private GameManager()
    {
        Score = 0;

        // Inicializa os jogadores com nome e monstro
        Player1 = CreatePlayer("Jogador 1");
        Player2 = CreatePlayer("Jogador 2");
    }

    // Método para criar jogadores com um monstro escolhido
    private Player CreatePlayer(string playerName)
    {
        Console.WriteLine($"Escolha um monstro para {playerName}: Dragon, Zombie, Robot, Golem, Phoenix");
        string monsterType = Console.ReadLine();

        // Cria o monstro com base no tipo escolhido
        Monster chosenMonster = MonsterFactory.CreateMonster(monsterType);

        // Cria o jogador com nome e monstro escolhido
        return new Player(playerName, chosenMonster);
    }

    // Métodos para gerenciar o estado do jogo
    public void AddScore(int points)
    {
        Score += points;
    }

    public void ResetScore()
    {
        Score = 0;
    }

    public void DisplayPlayersInfo()
    {
        Console.WriteLine($"{Player1.Name}: Monstro = {Player1.Monster.Name}, Vida = {Player1.Monster.Health}, Pontos = {Player1.Score}");
        Console.WriteLine($"{Player2.Name}: Monstro = {Player2.Monster.Name}, Vida = {Player2.Monster.Health}, Pontos = {Player2.Score}");
    }

    public void SetPlayers(Player player1, Player player2)
    {
        Player1 = player1;
        Player2 = player2;
    }
}
