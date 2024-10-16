public class GameUI
{
    public void DisplayStatus(Monster player1Monster, Monster player2Monster)
    {
        Console.Clear();
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"Jogador 1: {player1Monster.Name} (Vida: {player1Monster.Health})");
        Console.WriteLine($"Jogador 2: {player2Monster.Name} (Vida: {player2Monster.Health})");
        Console.WriteLine("------------------------------------\n");
    }

    public void ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("===== Batalha de Monstros =====");
        Console.WriteLine("1. Novo Jogo (1 jogador)");
        Console.WriteLine("2. Novo Jogo (2 jogadores)");
        Console.WriteLine("3. Carregar Jogo");
        Console.WriteLine("4. Sair");
        Console.Write("Escolha uma opção: ");
    }
}
