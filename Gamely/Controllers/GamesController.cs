using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Gamely.Models;
using Gamely.ViewModels;

namespace Gamely.Controllers
{
    public class GamesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Game
        public ActionResult Index()
        {
            var games = _context.Games.Include(m => m.Genre).ToList();
            return View(games);
        }

        public ActionResult Details(int id)
        {
            var game = _context.Games.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);
            if (game == null)

            {
                return HttpNotFound();
            }
            return View(game);

        }

        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new GameFormViewModel()
            {
                Genres = genres,
                Game = new Game()
            };

            return View("GameForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null)
                return HttpNotFound();

            var viewModel = new GameFormViewModel()
            {
                Game = game,
                Genres = _context.Genres.ToList()
            };

            return View("GameForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Game game)
        {
            var errors = ModelState
                        .Where(x => x.Value.Errors.Count > 0)
                        .Select(x => new { x.Key, x.Value.Errors })
                        .ToArray();
            if (!ModelState.IsValid)
            {
                var viewModel = new GameFormViewModel()
                {
                    Game = game,
                    Genres = _context.Genres.ToList()
                };
                return View("GameForm", viewModel);
            }

            if (game.Id == 0)
            {
                game.DateAdded = DateTime.Now.ToString("yyyy-MM-dd");
                _context.Games.Add(game);
            }
            else
            {
                var gameInDb = _context.Games.Single(g => g.Id == game.Id);
                gameInDb.Name = game.Name;
                gameInDb.ReleaseDate = game.ReleaseDate;
                gameInDb.NumberInStock = game.NumberInStock;
                gameInDb.GenreId = game.GenreId;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Games");
        }
    }
}