public class MonsterFactory
{
    public Monster CreateMonster(string type)
    {
        return type switch
        {
            "Dragão" => new Dragon(),
            "Zumbi" => new Zombie(),
            "Robô" => new Robot(),
            _ => throw new ArgumentException("Tipo de monstro inválido")
        };
    }
}
