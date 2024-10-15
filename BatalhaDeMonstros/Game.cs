public class Game
{
    private MonsterFactory _monsterFactory;
    private GameSaver _gameSaver;
    private GameState _gameState;

    public Game()
    {
        _monsterFactory = new MonsterFactory();
        _gameSaver = new GameSaver();
    }

    public void Start()
    {
        Console.WriteLine("Bem-vindo ao jogo Batalha de Monstros!");
        MainMenu();
    }

    private void MainMenu()
    {
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
                Console.WriteLine("Escolha inválida. Tente novamente.");
                MainMenu();
                break;
        }
    }

    private void NewGame()
    {
        Console.WriteLine("Escolha seu monstro: Dragão, Zumbi, Robô");
        string monsterType = Console.ReadLine();

        Monster playerMonster = _monsterFactory.CreateMonster(monsterType);
        Player player = new Player(playerMonster);

        Monster enemyMonster = _monsterFactory.CreateMonster("Zumbi"); // Aqui você pode gerar inimigos aleatórios
        Battle(player, enemyMonster);
    }

    private void LoadGame()
    {
        Console.WriteLine("Carregando jogo...");
        GameMemento memento = _gameSaver.Load("savegame.json");
        _gameState = memento.State;

        Player player = _gameState.Player;
        Monster enemyMonster = _gameState.EnemyMonster;

        Battle(player, enemyMonster);
    }

    private void Battle(Player player, Monster enemy)
    {
        EnemyAI enemyAI = new EnemyAI(); // Crie a instância do EnemyAI aqui

        while (player.Monster.Health > 0 && enemy.Health > 0)
        {
            // Exibir status dos monstros
            Console.WriteLine($"Seu monstro: {player.Monster.Name} (Vida: {player.Monster.Health})");
            Console.WriteLine($"Monstro inimigo: {enemy.Name} (Vida: {enemy.Health})");

            // Jogador escolhe ação
            Console.WriteLine("Escolha uma ação: 1. Atacar, 2. Defender, 3. Usar habilidade especial");
            string actionChoice = Console.ReadLine();
            IActionStrategy playerAction = actionChoice switch
            {
                "1" => new AttackAction(),
                "2" => new DefendAction(),
                "3" => new SpecialAbilityAction(),
                _ => throw new ArgumentOutOfRangeException()
            };

            playerAction.Execute(player.Monster, enemy);
            if (enemy.Health <= 0)
            {
                Console.WriteLine("Você venceu!");
                return;
            }

            // Inimigo faz sua jogada
            enemyAI.TakeTurn(enemy, player.Monster);
            if (player.Monster.Health <= 0)
            {
                Console.WriteLine("Seu monstro foi derrotado. Game Over!");
                return;
            }
        }
    }
}
