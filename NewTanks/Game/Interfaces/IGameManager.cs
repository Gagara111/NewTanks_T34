namespace NewTanks.Game.Interfaces
{
    public interface IGameManager
    {
        IGameTanks GetGameTanks (IGameCredentials? credentials);
        void InitGame (IGameCredentials? credentials);
    }
}
