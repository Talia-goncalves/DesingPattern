public class MonsterFactory
{
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
}
