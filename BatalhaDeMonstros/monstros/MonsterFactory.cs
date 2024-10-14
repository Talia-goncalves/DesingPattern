public static class MonsterFactory
{
    public static Monster CreateMonster(string type)
    {
        return type switch
        {
            "Dragon" => new Dragon { Name = "Dragon" },
            "Zombie" => new Zombie { Name = "Zombie" },
            "Robot" => new Robot { Name = "Robot" },
            "Golem" => new Golem { Name = "Golem" },
            "Phoenix" => new Phoenix { Name = "Phoenix" },
            _ => throw new ArgumentException("Invalid monster type")
        };
    }
}