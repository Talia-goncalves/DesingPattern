public class HealthObserver : IObserver
{
    public void Update(Monster monster)
    {
        Console.WriteLine($"{monster.Name}'s health is now {monster.Health}.");
    }
}