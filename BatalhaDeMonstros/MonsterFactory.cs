public static class MonsterFactory
{
    public static Monster CreateMonster(string type)
    {
        switch (type.ToLower())
        {
            case "dragao":
                return new Dragao();
            case "zumbi":
                return new Zumbi();
            case "robo":
                return new Robo();
            default:
                throw new ArgumentException("Tipo de monstro desconhecido.");
        }
    }
}
