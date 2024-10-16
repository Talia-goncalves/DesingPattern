public class Game
{
    private Player? player1; // Declarado como anulável
    private Player? player2; // Declarado como anulável
    private MonsterFactory _monsterFactory;

    public Game()
    {
        _monsterFactory = new MonsterFactory();
    }

    public void Start()
    {
        Console.WriteLine("Bem-vindo ao jogo Batalha de Monstros!");
        MainMenu();
    }

    private void MainMenu()
    {
        Console.WriteLine("Escolha o modo de jogo:");
        Console.WriteLine("1. Jogar contra a IA");
        Console.WriteLine("2. Jogar contra outro jogador");
        string modeChoice = Console.ReadLine();

        if (modeChoice == "1")
        {
            StartGameAgainstAI();
        }
        else if (modeChoice == "2")
        {
            StartGameAgainstPlayer();
        }
        else
        {
            Console.WriteLine("Escolha inválida, tente novamente.");
            MainMenu();
        }
    }

    private void StartGameAgainstAI()
    {
        Console.WriteLine("Escolha o monstro do jogador 1:");
        Console.WriteLine("1. Robô");
        Console.WriteLine("2. Elfo");
        Console.WriteLine("3. Zombie");
        string choice1 = Console.ReadLine();

        player1 = CreatePlayer(choice1);
        player2 = CreateAIPlayer(); // Cria o jogador 2 como IA

        Battle(player1, player2);
    }

    private void StartGameAgainstPlayer()
    {
        Console.WriteLine("Escolha o monstro do jogador 1:");
        Console.WriteLine("1. Robô");
        Console.WriteLine("2. Elfo");
        Console.WriteLine("3. Zombie");
        string choice1 = Console.ReadLine();

        player1 = CreatePlayer(choice1);

        Console.WriteLine("Escolha o monstro do jogador 2:");
        string choice2 = Console.ReadLine();
        player2 = CreatePlayer(choice2);

        Battle(player1, player2);
    }

    private Player CreatePlayer(string choice)
    {
        Monster monster = choice switch
        {
            "1" => new Robot(),
            "2" => new Elfo(),
            "3" => new Zombie(),
            _ => throw new ArgumentException("Escolha inválida")
        };
        return new Player(monster);
    }

    private Player CreateAIPlayer()
    {
        Monster monster = _monsterFactory.CreateRandomMonster(); // Cria um monstro aleatório
        Console.WriteLine($"IA escolheu: {monster.Name}");
        return new Player(monster);
    }

    private void Battle(Player player1, Player player2)
    {
        Console.WriteLine("Iniciando batalha entre " + player1.Monster.Name + " e " + player2.Monster.Name);

        while (player1.Monster.Health > 0 && player2.Monster.Health > 0)
        {
            player1.ChooseAction(player2); // Jogador 1 escolhe ação
            
            // IA se defende se o jogador humano atacou
            player2.Monster.SetDefending(false); // Reseta a defesa após a ação do jogador
            if (player2.Monster.Health <= 0)
            {
                Console.WriteLine($"{player2.Monster.Name} foi derrotado!");
                break;
            }

            // IA ataca após a ação do jogador
            AIChooseAction(player2, player1); // Jogador 2 (IA) escolhe ação
            
            if (player1.Monster.Health <= 0)
            {
                Console.WriteLine($"{player1.Monster.Name} foi derrotado!");
                break;
            }
        }
    }

    private void AIChooseAction(Player aiPlayer, Player target)
    {
        Random rand = new Random();
        int actionChoice = rand.Next(1, 3); // 1 ou 2 (atacar ou defender)

        if (actionChoice == 1)
        {
            int damage = aiPlayer.Monster.NormalAttack();
            target.Monster.TakeDamage(damage);
            Console.WriteLine($"{aiPlayer.Monster.Name} ataca {target.Monster.Name} causando {damage} de dano!");
        }
        else
        {
            aiPlayer.Monster.SetDefending(true);
            Console.WriteLine($"{aiPlayer.Monster.Name} está se defendendo!");
        }
    }
}