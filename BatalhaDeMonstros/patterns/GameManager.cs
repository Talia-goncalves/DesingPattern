using System;

public class GameManager
{
    // Singleton instance
    private static GameManager _instance = new GameManager(); // Inicializa a instância
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
        Score = 0; // Inicializa a pontuação
        Player1 = new Player("Jogador 1"); // Inicializa Jogador 1
        Player2 = new Player("Jogador 2"); // Inicializa Jogador 2
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
        Console.WriteLine($"{Player1.Name}: Vida = {Player1.Health}, Pontos = {Player1.Score}");
        Console.WriteLine($"{Player2.Name}: Vida = {Player2.Health}, Pontos = {Player2.Score}");
    }

    public void SetPlayers(Player player1, Player player2)
    {
        Player1 = player1;
        Player2 = player2;
    }
}

// Classe para representar o jogador
public class Player
{
    public string Name { get; private set; }
    public int Health { get; set; }
    public int Score { get; set; }

    public Player(string name)
    {
        Name = name;
        Health = 100; // Vida inicial do jogador
        Score = 0; // Pontuação inicial do jogador
    }
}
