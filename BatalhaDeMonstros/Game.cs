using System;

public class Game
{
    private GameSaver gameSaver;
    private GameState gameState;

    public Game()
    {
        gameSaver = new GameSaver();
        gameState = new GameState();
    }

    public void Start()
    {
        // Exemplo de menu inicial
        Console.WriteLine("Bem-vindo ao jogo Batalha de Monstros!");
        Console.WriteLine("1. Novo Jogo");
        Console.WriteLine("2. Carregar Jogo");
        Console.WriteLine("3. Sair");
        
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                NewGame();
                break;
            case "2":
                LoadGame();
                break;
            case "3":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                Start();
                break;
        }
    }

    private void NewGame()
    {
        gameState = new GameState();
        Console.WriteLine("Novo jogo iniciado!");
    }

    private void LoadGame()
    {
        try
        {
            GameMemento memento = gameSaver.Load("save.json");
            gameState.PlayerScore = memento.PlayerScore;
            gameState.EnemyScore = memento.EnemyScore;
            Console.WriteLine("Jogo carregado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao carregar o jogo: {ex.Message}");
        }
    }
}
