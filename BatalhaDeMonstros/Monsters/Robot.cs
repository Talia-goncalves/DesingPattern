namespace BatalhaDeMonstros.Monsters
{
    public class Robot : Monster
    {
        public Robot() : base(health: 90, attackPower: 15, defense: 12) { }

        public override void UseSpecialAbility(Monster target)
        {
            Console.WriteLine($"{GetType().Name} usa habilidade especial: Laser Beam!");
            target.Health -= 20;
        }
    }
}
