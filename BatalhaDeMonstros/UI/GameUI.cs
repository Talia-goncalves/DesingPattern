public class GameUI
{
    public void DisplayStatus(Monster playerMonster, Monster enemyMonster)
    {
        Console.Clear();
        Console.WriteLine($"{playerMonster.Name} (Vida: {playerMonster.Health}) vs {enemyMonster.Name} (Vida: {enemyMonster.Health})");
    }
}
