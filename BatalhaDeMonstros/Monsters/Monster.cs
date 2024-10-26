namespace BatalhaDeMonstros.Monsters
{
    public class Monster
    {
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; private set; } // Defesa encapsulada

        public Monster(int health, int attackPower, int defense)
        {
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }

        public void IncreaseDefense(int amount) => Defense += amount; // Método para aumentar a defesa

        public virtual void UseSpecialAbility(Monster target) { }
    }
}
