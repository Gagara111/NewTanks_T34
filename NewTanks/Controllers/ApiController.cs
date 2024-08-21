using Microsoft.AspNetCore.Mvc;
using NewTanks.Game.Interfaces;
using NewTanks.Models;

namespace NewTanks.Controllers;


[ApiController]
public class ApiController(IProfile _profile, IGameManager _gameManager ) : Controller
{
    [HttpPost]
    [Route(nameof(Login))]
public IActionResult Login([FromForm]string login, [FromForm] string password) 
{
    if (_profile.ValidateProfile(login, password))

    {
        return new RedirectToActionResult(
            "Lobby" , "Game", null);
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


