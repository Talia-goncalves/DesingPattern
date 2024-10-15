public abstract class Monster
{
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Health { get; set; }

    public abstract void UseSpecialAbility(Monster target);
}
