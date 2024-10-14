public class Memento
{
    public int Health { get; }
    public int Attack { get; }
    public int Defense { get; }

    public Memento(int health, int attack, int defense)
    {
        Health = health;
        Attack = attack;
        Defense = defense;
    }
}