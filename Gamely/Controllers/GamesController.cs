using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Gamely.Models;

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

        
    }
}