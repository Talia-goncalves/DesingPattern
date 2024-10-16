using System;

public class MonsterFactory
{
    private static readonly string[] MonsterTypes = { "elfo", "zumbi", "robô" }; // Tipos de monstros

    public Monster CreateMonster(string type)
    {
        return type.ToLower() switch
        {
            "elfo" => new Elfo(),
            "zumbi" => new Zombie(),
            "robô" => new Robot(),
            _ => throw new ArgumentException("Tipo de monstro inválido")
        };
    }

    // Método para criar um monstro aleatório
    public Monster CreateRandomMonster()
    {
        var random = new Random();
        string randomType = MonsterTypes[random.Next(MonsterTypes.Length)];
        return CreateMonster(randomType);
    }
}
