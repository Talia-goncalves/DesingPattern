using System;

public class Player
{
    public string Name { get; private set; }
    public Monster Monster { get; private set; }

    public Player(string name)
    {
        Name = name;
        ChooseMonster();
    }

    private void ChooseMonster()
    {
        Console.WriteLine($"{Name}, escolha seu monstro (dragao, zumbi, robo): ");
        string choice = Console.ReadLine();
        Monster = MonsterFactory.CreateMonster(choice);
    }
}
