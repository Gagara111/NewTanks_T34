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
    public void Right()
    {

    }

    public void Up()
    {

    }
    public void Down()
    {

    }
    public void Left()
    {

    }

        public class DirectionController : ControllerBase
    {
        [HttpPost("Left")]
        public IActionResult Left()
        {
            // Логика для движения влево
            return Ok("Moved Left");
        }

        [HttpPost("Right")]
        public IActionResult Right()
        {
            // Логика для движения вправо
            return Ok("Moved Right");
        }

        [HttpPost("Up")]
        public IActionResult Up()
        {
            // Логика для движения вверх
            return Ok("Moved Up");
        }

        [HttpPost("Down")]
        public IActionResult Down()
        {
            // Логика для движения вниз
            return Ok("Moved Down");
        }
    }
}


