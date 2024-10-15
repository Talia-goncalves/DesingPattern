public abstract class Monster
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int DefensePower { get; set; }

    protected Monster(string name, int health, int attackPower, int defensePower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        DefensePower = defensePower;
    }

    public virtual int Attack()
    {
        return AttackPower;
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= Math.Max(damage - DefensePower, 0);
    }

    public abstract void UseSpecialAbility(Monster target);
}
