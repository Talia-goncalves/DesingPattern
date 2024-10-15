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

    // Escolha do Jogador 1
    Console.Write("Digite o nome do Jogador 1: ");
    string playerName1 = Console.ReadLine() ?? "Jogador 1";
    Console.WriteLine("Escolha um monstro para o Jogador 1:");
    Monster monster1 = ChooseMonster();

    // Escolha do Jogador 2
    Console.Write("Digite o nome do Jogador 2: ");
    string playerName2 = Console.ReadLine() ?? "Jogador 2";
    Console.WriteLine("Escolha um monstro para o Jogador 2:");
    Monster monster2 = ChooseMonster();

    // Criação dos jogadores com o monstro escolhido
    Player p1 = new Player(playerName1, monster1);
    Player p2 = new Player(playerName2, monster2);

    // Configurando os jogadores no GameManager
    gameManager.SetPlayers(p1, p2);

    // Exibindo a escolha dos monstros
    Console.WriteLine($"{gameManager.Player1.Name} escolheu {gameManager.Player1.Monster.Name}.");
    Console.WriteLine($"{gameManager.Player2.Name} escolheu {gameManager.Player2.Monster.Name}.");

    // Inicia a batalha
    Battle battle = new Battle(gameManager.Player1, gameManager.Player2);
    battle.Start();

    // Voltar ao menu principal após a batalha
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
}

// Método para escolher um monstro
static Monster ChooseMonster()
{
    Console.WriteLine("1. Phoenix");
    Console.WriteLine("2. Robot");
    Console.WriteLine("3. Zombie");
    Console.WriteLine("4. Dragon");

    while (true)
    {
        Console.Write("Escolha o monstro (1-4): ");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                return new Phoenix();
            case "2":
                return new Robot();
            case "3":
                return new Zombie();
            case "4":
                return new Dragon();
            default:
                Console.WriteLine("Escolha inválida, tente novamente.");
                break;
        }
    }
}

}
