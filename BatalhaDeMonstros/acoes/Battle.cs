public class Battle
{
    public void StartBattle(Monster monster1, Monster monster2)
    {
        Console.WriteLine($"A battle begins between {monster1.Name} and {monster2.Name}!");

        while (monster1.Health > 0 && monster2.Health > 0)
        {
            // Turno do Monster1
            PlayerTurn(monster1, monster2);

            // Verifica se o Monster2 ainda está vivo
            if (monster2.Health <= 0)
            {
                Console.WriteLine($"{monster1.Name} wins!");
                break;
            }

            // Turno do Monster2
            PlayerTurn(monster2, monster1);

            // Verifica se o Monster1 ainda está vivo
            if (monster1.Health <= 0)
            {
                Console.WriteLine($"{monster2.Name} wins!");
                break;
            }
        }
    }

    private void PlayerTurn(Monster attacker, Monster defender)
    {
        Console.WriteLine($"\n{attacker.Name}'s turn! Choose an action:");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Defend");
        Console.WriteLine("3. Use Special Move");

        string? choice;
        do
        {
            choice = Console.ReadLine();

            if (string.IsNullOrEmpty(choice) || (choice != "1" && choice != "2" && choice != "3"))
            {
                Console.WriteLine("Invalid choice, please choose 1, 2, or 3.");
            }
        } while (string.IsNullOrEmpty(choice) || (choice != "1" && choice != "2" && choice != "3"));

        IAction action;
        switch (choice)
        {
            case "1":
                action = new AttackAction();
                break;
            case "2":
                action = new DefendAction();
                break;
            case "3":
                action = new SpecialMoveAction();
                break;
            default:
                action = new AttackAction(); // Não chegará aqui, mas adicionamos por segurança
                break;
        }

        action.Execute(attacker, defender);
        Console.WriteLine($"{defender.Name}'s Health: {defender.Health}");
    }
}
