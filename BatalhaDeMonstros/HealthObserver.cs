public class HealthObserver
{
    public void Notify(Monster monster)
    {
        Console.WriteLine($"{monster.Name} tem agora {monster.Health} de vida.");
    }
}
