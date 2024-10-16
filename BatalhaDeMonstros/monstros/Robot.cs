public class Robot : Monster
{
    public Robot() : base("Robô", 120, 25)
    {
    }

    public void UseSpecialAbility(Monster target)
    {
        // Habilidade especial do robô
        Console.WriteLine($"{Name} dispara um laser em {target.Name}, causando 20 de dano!");
        target.RestoreState(new Memento(target.Name, target.Health - 20, target.Attack));
    }
}
