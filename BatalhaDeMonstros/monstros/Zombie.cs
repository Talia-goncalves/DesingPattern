public class Zombie : Monster
{
    public Zombie() : base("Zombie", 100, 15)
    {
    }

    public void UseSpecialAbility(Monster target)
    {
        // Habilidade especial do zumbi
        Console.WriteLine($"{Name} infecta {target.Name}, causando 10 de dano!");
        target.RestoreState(new Memento(target.Name, target.Health - 10, target.Attack));
    }
}
