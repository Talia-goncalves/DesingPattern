using System;

public abstract class Monster
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Attack { get; private set; }
    public bool IsDefending { get; private set; } // Adicionando estado de defesa

    protected Monster(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
        IsDefending = false; // Inicialmente não está defendendo
    }

    public void TakeDamage(int damage)
    {
        if (IsDefending)
        {
            damage /= 2; // Reduzindo dano pela metade se defendendo
            Console.WriteLine($"{Name} está defendendo! Dano reduzido para {damage}.");
        }

        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} sofreu {damage} de dano! Saúde restante: {Health}");
    }

    public void SetDefending(bool defending)
    {
        IsDefending = defending; // Atualizando estado de defesa
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
        IsDefending = false; // Reseta defesa ao restaurar
    }

    public abstract void UseSpecialAbility(Monster target); // Método abstrato
    public int NormalAttack() => Attack; // Adicionando ataque normal

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
