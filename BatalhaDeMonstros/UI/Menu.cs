using System;

public class Menu
{
    public void ShowMainMenu()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao jogo Batalha de Monstros!");
        Console.WriteLine("1. Novo Jogo");
        Console.WriteLine("2. Carregar Jogo");
        Console.WriteLine("3. Sair");
        Console.Write("Escolha uma opção: ");
    }
}
