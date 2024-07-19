using Microsoft.AspNetCore.Mvc;
using NewTanks.Game.Interfaces;
using NewTanks.Models;

namespace NewTanks.Controllers
{
    public class ApiController
    {
    }
}
public class ApiController(IProfile profile, IGameManager _gameManager );

public IActionResult Login([FromForm]string login, [FromForm] string password)   // с этого места виден экран преподавателя!!!!!!!!!!!!!!!!!
{
    if (_profile.ValidateProfile(login, password))

    {
        return new RedirectToActionResult(login"Lobby", "Game", null);
    }

    return new JsonResult("Failure");

}

[HttpPost]
[Route(nameof(StartGame))]

    public IActionResult StartGame()
     {
    var gameTanks = _gameManager.GetGameTanks(null);
    gameTanks.StartGame();
    var gameModel = new GameModel(gameTanks);

    return PartialView("GameField", gameModel.GameFieldModel);

     }
}



