public class Monster
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Attack { get; private set; }

    public Monster(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
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
