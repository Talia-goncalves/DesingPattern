using BatalhaDeMonstros.Actions;
using BatalhaDeMonstros.Monsters;
using BatalhaDeMonstros.Observers;

namespace BatalhaDeMonstros.Game
{
    public class Game
    {
        private readonly List<Monster> _monsters = new();
        private readonly bool _isPvE;
        private readonly AIPlayer.AIPlayer _aiPlayer = new();
        private readonly HealthObserver _healthObserver = new();

        public Game(bool isPvE)
        {
            _isPvE = isPvE;
        }

        public void AddMonster(Monster monster) => _monsters.Add(monster);

        public void Start()
        {
            Console.WriteLine("Iniciando batalha!");
            var playerMonster = _monsters[0];
            var opponentMonster = _monsters[1];

            while (playerMonster.Health > 0 && opponentMonster.Health > 0)
            {
                ExecuteTurn(playerMonster, opponentMonster);

                if (opponentMonster.Health > 0)
                {
                    if (_isPvE)
                    {
                        ExecuteTurnAI(opponentMonster, playerMonster);
                    }
                    else
                    {
                        ExecuteTurn(opponentMonster, playerMonster);
                    }
                }

                _healthObserver.OnHealthChanged(playerMonster);
                _healthObserver.OnHealthChanged(opponentMonster);
            }

            GameManager.Instance.Score += playerMonster.Health > 0 ? 10 : 0;
            Console.WriteLine(playerMonster.Health > 0 ? "Jogador vence!" : "Oponente vence!");
        }

        private void ExecuteTurn(Monster attacker, Monster defender)
        {
            Console.WriteLine($"\n{attacker.GetType().Name} - Escolha uma ação: (1) Atacar (2) Defender (3) Habilidade Especial");
            int choice = int.Parse(Console.ReadLine() ?? "1");

            ICombatAction action = choice switch
            {
                1 => new AttackAction(),
                2 => new DefendAction(),
                3 => new SpecialAction(),
                _ => throw new ArgumentException("Ação inválida.")
            };

            action.Execute(attacker, defender);
            Console.WriteLine($"{defender.GetType().Name} tem {defender.Health} de vida restante.");
        }

        private void ExecuteTurnAI(Monster attacker, Monster defender)
        {
            var action = _aiPlayer.ChooseAction(attacker, defender);
            action.Execute(attacker, defender);
            Console.WriteLine($"{defender.GetType().Name} tem {defender.Health} de vida restante.");
        }
    }
}
