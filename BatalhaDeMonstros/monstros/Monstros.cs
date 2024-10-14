public abstract class Monster
{
    public required string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public abstract void SpecialMove();
}