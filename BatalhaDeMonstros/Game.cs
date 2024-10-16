using System;
using System.Collections.Generic;

public class Game
{
    private Player player1;
    private Player player2;
    private MonsterFactory _monsterFactory;
    private Stack<Monster.Memento> _mementosPlayer1;
    private Stack<Monster.Memento> _mementosPlayer2;

    public Game()
    {
        _monsterFactory = new MonsterFactory();
        _mementosPlayer1 = new Stack<Monster.Memento>();
        _mementosPlayer2 = new Stack<Monster.Memento>();
    }

    public void Start()
    {
        Console.WriteLine("Bem-vindo ao jogo Batalha de Monstros!");
        MainMenu();
    }

    private void MainMenu()
    {
        Console.WriteLine("1. Jogar contra IA");
        Console.WriteLine("2. Jogar contra outro jogador");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            // Jogar contra IA, criando monstros aleatórios
            player1 = new Player(_monsterFactory.CreateRandomMonster());
            player2 = new Player(_monsterFactory.CreateRandomMonster()); // IA como Player 2
            Battle(player1, player2);
        }
        else if (choice == "2")
        {
            // Jogar contra outro jogador, criando monstros aleatórios
            player1 = new Player(_monsterFactory.CreateRandomMonster());
            player2 = new Player(_monsterFactory.CreateRandomMonster());
            Battle(player1, player2);
        }
        else
        {
            Console.WriteLine("Escolha inválida. Tente novamente.");
            MainMenu(); // Repete o menu se a escolha for inválida
        }
    }

    private void Battle(Player player1, Player player2)
    {
        // Lógica para batalha entre os jogadores
        Console.WriteLine("Iniciando batalha entre " + player1.Monster.Name + " e " + player2.Monster.Name);
        // Implemente a lógica de batalha aqui
    }

    private void SaveMonsterState(Player player)
    {
        var memento = player.Monster.SaveState();
        if (player == player1)
        {
            _mementosPlayer1.Push(memento);
        }
        else
        {
            _mementosPlayer2.Push(memento);
        }
        Console.WriteLine("Estado salvo!");
    }

    private void RestoreMonsterState(Player player)
    {
        if (player == player1 && _mementosPlayer1.Count > 0)
        {
            player.Monster.RestoreState(_mementosPlayer1.Pop());
        }
        else if (player == player2 && _mementosPlayer2.Count > 0)
        {
            player.Monster.RestoreState(_mementosPlayer2.Pop());
        }
        else
        {
            Console.WriteLine("Nenhum estado salvo para restaurar!");
        }
    }
}
