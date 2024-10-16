public abstract class Monster
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Attack { get; private set; }

    protected Monster(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} sofreu {damage} de dano! Saúde restante: {Health}");
    }

    public Memento SaveState()
    {
        return new Memento(Name, Health, Attack);
    }

    public void RestoreState(Memento memento)
    {
        Name = memento.Name;
        Health = memento.Health;
        Attack = memento.Attack;
    }

    public class Memento
    {
        public string Name { get; }
        public int Health { get; }
        public int Attack { get; }

        public Memento(string name, int health, int attack)
        {
            Name = name;
            Health = health;
            Attack = attack;
        }
    }
}
