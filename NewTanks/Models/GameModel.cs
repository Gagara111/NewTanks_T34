using NewTanks.Game.Interfaces;

namespace NewTanks.Models
{
    public class GameModel
    {
        public GameFieldModel GameFieldModel { get; private set; }
        public GameFightFieldModel GameFightFieldModel { get; private set; }

        public GameModel(IGameTanks game)
        {
            GameFieldModel = new GameFieldModel(game);
            GameFightFieldModel = new GameFightFieldModel(game);

        }
    }
}
