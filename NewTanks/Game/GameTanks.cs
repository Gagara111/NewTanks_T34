using NewTanks.Game.Interfaces;
using NewTanks.Models;

namespace NewTanks.Game
{
    public class GameTanks : IGameTanks
    {
        public GameField GameField { get; private set; }
        public void EndGame()
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
