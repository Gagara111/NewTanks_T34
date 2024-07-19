using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewTanks.Game.Interfaces;
using NewTanks.Models;
using NuGet.Configuration;

namespace NewTanks.Controllers
{
    public class GameController(IGameManager _gameManager) : Controller
    {
        public void Lobby()
        {

        }

        public IActionResult Game()
        {
            var game = _gameManager.GetGameTanks(null);
            var dataModel = new GameModel(game);
            return View(dataModel);
        }

    }
}
