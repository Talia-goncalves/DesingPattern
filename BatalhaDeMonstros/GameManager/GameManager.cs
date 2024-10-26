namespace BatalhaDeMonstros.GameManager
{
    public class GameManager
    {
        private static GameManager _instance;
        public int Score { get; set; }

        private GameManager() { }

        public static GameManager Instance => _instance ??= new GameManager();
    }
}
