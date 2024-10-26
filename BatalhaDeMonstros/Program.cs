using BatalhaDeMonstros.Game;
using BatalhaDeMonstros.Factory;

namespace BatalhaDeMonstros
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bem-vindo ao Jogo Batalha de Monstros!");
            Console.WriteLine("Escolha o modo de jogo: (1) PvP (2) PvE");
            int gameMode = int.Parse(Console.ReadLine() ?? "1");
            bool isPvE = gameMode == 2;

            var game = new Game.Game(isPvE);
            game.AddMonster(MonsterFactory.CreateMonster("Dragon"));
            game.AddMonster(MonsterFactory.CreateMonster("Robot")); // Adiciona o novo monstro "Robot"
            game.Start();
        }
    }
}
