namespace NewTanks.Models.Enums
{
    public static class CellTileExtention
    {
        private static Dictionary<GameCellTile, CellTile> _convertDictionary = new Dictionary<GameCellTile, CellTile>
        {
            { GameCellTile.Brick, CellTile.Brick },
            { GameCellTile.EnemyBase, CellTile.EnemyBase },
            { GameCellTile.FriendlyBase, CellTile.FriendlyBase },
            { GameCellTile.BadRock, CellTile.BadRock },
            { GameCellTile.Empty, CellTile.Empty },
        };
        public static CellTile ToCellTile(this GameCellTile source)
        {
            return _convertDictionary[source];
        }
    }
}
