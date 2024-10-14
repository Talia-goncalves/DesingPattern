using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Batalha de Monstros ===");
            Console.WriteLine("1. Novo Jogo");
            Console.WriteLine("2. Sair");
            Console.Write("Escolha uma opção: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    Console.WriteLine("Saindo do jogo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void StartGame()
    {
        Console.Clear();
        Console.WriteLine("=== Novo Jogo ===");

        GameManager gameManager = GameManager.Instance;

        Console.Write("Digite o nome do Jogador 1: ");
        string playerName1 = Console.ReadLine() ?? "Jogador 1";
        Console.Write("Digite o nome do Jogador 2: ");
        string playerName2 = Console.ReadLine() ?? "Jogador 2";

        Player p1 = new Player(playerName1);
        Player p2 = new Player(playerName2);

        gameManager.SetPlayers(p1, p2);

        Console.WriteLine($"{gameManager.Player1.Name} vs {gameManager.Player2.Name}");

        // Inicia a batalha
        Battle battle = new Battle(gameManager.Player1, gameManager.Player2);
        battle.Start();

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
        Console.ReadKey();
    }
}
