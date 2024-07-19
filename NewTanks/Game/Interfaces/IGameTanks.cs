using NewTanks.Models;

namespace NewTanks.Game.Interfaces
{
    public interface IGameTanks
    {
        GameField GameField { get; } // ссылка на GameField
        void StartGame();
        void EndGame();
    }
}
