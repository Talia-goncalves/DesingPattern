public class MonsterMemento
{
    public int Health { get; private set; }
    public int AttackPower { get; private set; }
    public int DefensePower { get; private set; }

    public MonsterMemento(int health, int attackPower, int defensePower)
    {
        Health = health;
        AttackPower = attackPower;
        DefensePower = defensePower;
    }
}
