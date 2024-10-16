public class MonsterFactory
{
    private Random _random = new Random();

    public Monster CreateRandomMonster()
    {
        int choice = _random.Next(1, 4);
        return choice switch
        {
            1 => new Robot(),
            2 => new Elfo(),
            3 => new Zombie(),
            _ => throw new InvalidOperationException("Opção inválida")
        };
    }
}
