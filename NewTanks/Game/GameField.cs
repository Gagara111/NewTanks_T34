using NewTanks.Game.Interfaces;
using NewTanks.Models.Enums;


namespace NewTanks.Models
{
    public class GameField
    {
        public int FieldHeight => 15;
        public int FieldWidth => 15;

        public GameCellTile[][] Map { get; private set; }

        public GameField()
        {
            Map = InitializeMap();
            GenerateMap();

        }

        private void GenerateMap()
        {
            GenerateBrickCells(30);
            GenerateBadRock();

            Map[^1][FieldWidth / 2] = GameCellTile.FriendlyBase;
            Map[0][FieldWidth / 2] = GameCellTile.EnemyBase;
        }

        private void GenerateBadRock()
        {
            for (int row = 2; row < FieldHeight - 2; row += 2)
            {
                for (int column = 2; column < FieldWidth - 2; column += 2)
                {
                    Map[row][column] = GameCellTile.BadRock;
                }
            }
        }
        private void GenerateBrickCells(int fillPercent)
        {
            Random random = new Random();

            for (int row = 0; row < FieldHeight; row++)
            {
                for (int column = 0; column < FieldWidth; column++)
                {
                    int randomValue = random.Next(0, 100);

                    if (randomValue <= fillPercent)
                    {

                        Map[row][column] = GameCellTile.Brick;


                    }
                }
            }

        }
        private GameCellTile[][] InitializeMap()
        {
            GameCellTile[][] map = new GameCellTile[FieldHeight][];

            for (int counter = 0; counter < FieldHeight; counter++)
            {
                map[counter] = new GameCellTile[FieldWidth];
                Array.Fill(map[counter], GameCellTile.Empty);
            }
            return map;
        }
    }

}

