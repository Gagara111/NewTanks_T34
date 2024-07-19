using NewTanks.Game.Interfaces;
using NewTanks.Models.Enums;


namespace NewTanks.Models
{
    public class GameField
    {
        public int FieldHeight => 15;
        public int FieldWidth => 15;

        public CellTile[][] Map { get; private set; }

        public GameField(IGameTanks game)
        {
            Map = InitializeMap();
            GenerateMap();

        }

        private void GenerateMap()
        {
            GenerateBrickCells(30);
            GenerateBadRock();

            Map[^1][FieldWidth / 2] = CellTile.FriendlyBase;
            Map[0][FieldWidth / 2] = CellTile.EnemyBase;
        }

        private void GenerateBadRock()
        {
            for (int row = 2; row < FieldHeight - 2; row += 2)
            {
                for (int column = 2; column < FieldWidth - 2; column += 2)
                {
                    Map[row][column] = CellTile.BadRock;
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

                        Map[row][column] = CellTile.Brick;


                    }
                }
            }

        }
        private CellTile[][] InitializeMap()
        {
            CellTile[][] map = new CellTile[FieldHeight][];

            for (int counter = 0; counter < FieldHeight; counter++)
            {
                map[counter] = new CellTile[FieldWidth];
                Array.Fill(map[counter], CellTile.Empty);
            }
            return map;
        }
    }

}

