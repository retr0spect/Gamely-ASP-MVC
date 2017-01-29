using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Gamely.Models;

namespace Gamely.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            var games = GetGames();
            return View(games);
        }

        private IEnumerable<Game> GetGames()
        {
            return new List<Game>
            {
                new Game { Id = 1, Name = "BattleField 1" },
                 new Game { Id = 2, Name = "Planet Coaster" }
            };
        }
    }
}