public static class MonsterFactory
{
    public static Monster CreateMonster(string type)
    {
        return type switch
        {
            "Dragon" => new Dragon(),
            "Zombie" => new Zombie(),
            "Robot" => new Robot(),
            "Golem" => new Golem(),
            "Phoenix" => new Phoenix(),
            _ => throw new ArgumentException("Invalid monster type")
        };
    }
}
