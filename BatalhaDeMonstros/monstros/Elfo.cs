public class Elfo : Monster
{
    public Elfo() : base("Elfo", 80, 20)
    {
    }

    public void UseSpecialAbility(Monster target)
    {
        // Habilidade especial do elfo
        Console.WriteLine($"{Name} dispara uma flecha mágica em {target.Name}, causando 15 de dano!");
        target.RestoreState(new Memento(target.Name, target.Health - 15, target.Attack));
    }
}
