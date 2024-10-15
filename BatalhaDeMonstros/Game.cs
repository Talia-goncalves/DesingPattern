using System;

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
        EnemyAI enemyAI = new EnemyAI();

        Battle(player, enemyMonster);
    }

    private void LoadGame()
    {
        Console.WriteLine("Carregando jogo...");
        GameMemento memento = _gameSaver.Load("savegame.dat");
        _gameState = memento.State;

        Player player = _gameState.Player;
        Monster enemyMonster = _gameState.EnemyMonster;

        Battle(player, enemyMonster);
    }

    private void Battle(Player player, Monster enemy)
    {
        while (player.Monster.Health > 0 && enemy.Health > 0)
        {
            // Exibir status dos monstros
            Console.WriteLine($"Seu monstro: {player.Monster.Name} (Vida: {player.Monster.Health})");
            Console.WriteLine($"Monstro inimigo: {enemy.Name} (Vida: {enemy.Health})");

            // Jogador escolhe ação
            Console.WriteLine("Escolha sua ação: 1. Atacar 2. Defender 3. Usar Habilidade Especial");
            string actionChoice = Console.ReadLine();

            IActionStrategy actionStrategy = actionChoice switch
            {
                "1" => new AttackAction(),
                "2" => new DefendAction(),
                "3" => new SpecialAbilityAction(),
                _ => throw new InvalidOperationException("Ação inválida.")
            };

            actionStrategy.Execute(player.Monster, enemy);

            // Verificar se o inimigo foi derrotado
            if (enemy.Health <= 0)
            {
                Console.WriteLine($"{enemy.Name} foi derrotado! Você venceu!");
                SaveGame(player, enemy);
                break;
            }

            // Turno do inimigo
            EnemyAI enemyAI = new EnemyAI();
            enemyAI.TakeTurn(enemy, player.Monster);

            // Verificar se o jogador foi derrotado
            if (player.Monster.Health <= 0)
            {
                Console.WriteLine($"{player.Monster.Name} foi derrotado! Você perdeu!");
            }
        }
    }

    private void SaveGame(Player player, Monster enemy)
    {
        GameState gameState = new GameState
        {
            Player = player,
            EnemyMonster = enemy
        };
        GameMemento memento = new GameMemento(gameState);
        _gameSaver.Save(memento, "savegame.dat");
        Console.WriteLine("Jogo salvo com sucesso!");
    }
}
