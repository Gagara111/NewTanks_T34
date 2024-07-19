using NewTanks.Game.Interfaces;
using NewTanks.Models.Enums;

namespace NewTanks.Models
{
    public class GameFieldModel
    {
      
              public int FieldHeight { get; private set; }

              public int FieldWidth { get; private set; }

              public CellTile[][] Map { get; private set; }

              public GameFieldModel(IGameTanks game)
        {
            FieldHeight = game.GameField.FieldHeight;
            FieldWidth = game.GameField.FieldWidth;

            Map = game.GameField.Map.Select( // Select (linq)линк который  использует Toarray и Select 
                x => x.Select(y => y.ToCellTile()).ToArray()
            ).ToArray();
        }
    }

}
   


