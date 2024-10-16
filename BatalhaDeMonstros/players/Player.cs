public class Player
{
    public Monster Monster { get; private set; }

    public Player(Monster monster)
    {
        Monster = monster;
    }

    public void ChooseAction(Player opponent)
    {
        Console.WriteLine($"Escolha a ação para {Monster.Name}:");
        Console.WriteLine("1. Usar Habilidade Especial");
        Console.WriteLine("2. Ataque Normal");
        Console.WriteLine("3. Defender"); // Adicionando opção de defesa
        string actionChoice = Console.ReadLine();

        if (actionChoice == "1")
        {
            Monster.UseSpecialAbility(opponent.Monster);
        }
        else if (actionChoice == "2")
        {
            int damage = Monster.NormalAttack();
            opponent.Monster.TakeDamage(damage);
            Console.WriteLine($"{Monster.Name} ataca {opponent.Monster.Name} causando {damage} de dano!");
        }
        else if (actionChoice == "3")
        {
            Monster.SetDefending(true);
            Console.WriteLine($"{Monster.Name} está se defendendo!");
        }
        else
        {
            Console.WriteLine("Escolha inválida, tente novamente.");
            ChooseAction(opponent); // Repetir escolha se inválida
        }
    }
}