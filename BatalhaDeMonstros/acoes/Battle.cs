using System;

public class Battle
{
    private Player Player1 { get; set; }
    private Player Player2 { get; set; }

    public Battle(Player player1, Player player2)
    {
        Player1 = player1 ?? throw new ArgumentNullException(nameof(player1), "Player 1 cannot be null");
        Player2 = player2 ?? throw new ArgumentNullException(nameof(player2), "Player 2 cannot be null");
    }

    public void Start()
    {
        while (Player1.Health > 0 && Player2.Health > 0)
        {
            Console.Clear();
            DisplayStatus();

            // Turn for Player 1
            PlayerTurn(Player1, Player2);

            if (Player2.Health <= 0)
            {
                Console.WriteLine($"{Player1.Name} venceu a batalha!");
                return;
            }

            // Turn for Player 2
            PlayerTurn(Player2, Player1);

            if (Player1.Health <= 0)
            {
                Console.WriteLine($"{Player2.Name} venceu a batalha!");
                return;
            }
        }
    }

    private void DisplayStatus()
    {
        Console.WriteLine($"{Player1.Name} ({Player1.Monster.Name}): Vida = {Player1.Health}");
        Console.WriteLine($"{Player2.Name} ({Player2.Monster.Name}): Vida = {Player2.Health}");
    }

    private void PlayerTurn(Player attacker, Player defender)
    {
        Console.WriteLine($"{attacker.Name} ({attacker.Monster.Name}), é sua vez!");
        Console.WriteLine("Escolha uma ação: ");
        Console.WriteLine("1. Atacar");
        Console.WriteLine("2. Defender");
        Console.WriteLine("3. Habilidade Especial");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Attack(attacker, defender);
                break;
            case "2":
                Defend(attacker);
                break;
            case "3":
                UseSpecialAbility(attacker, defender);
                break;
            default:
                Console.WriteLine("Ação inválida, tente novamente.");
                PlayerTurn(attacker, defender);
                break;
        }
    }

    private void Attack(Player attacker, Player defender)
    {
        int damage = attacker.Monster.Attack - defender.Monster.Defense;
        damage = Math.Max(damage, 0);  // Garante que o dano não seja negativo
        defender.Health -= damage;
        Console.WriteLine($"{attacker.Name} ({attacker.Monster.Name}) atacou {defender.Name} ({defender.Monster.Name}) causando {damage} de dano!");
    }

    private void Defend(Player defender)
    {
        defender.Monster.Defense += 10;
        Console.WriteLine($"{defender.Name} ({defender.Monster.Name}) está se defendendo e aumenta sua defesa em 10!");
    }

    private void UseSpecialAbility(Player attacker, Player defender)
    {
        attacker.Monster.SpecialMove();
        // A lógica adicional de dano ou efeitos pode ser implementada aqui
    }
}
