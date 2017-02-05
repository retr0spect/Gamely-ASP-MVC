using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Gamely.Dtos;
using Gamely.Models;

namespace Gamely.Controllers.Api
{
    public class GamesController : ApiController
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/games
        public IHttpActionResult GetGames()
        {
            var gamesDtos = _context.Games.ToList().Select(Mapper.Map<Game, GamesDto>);
            return Ok(gamesDtos);
        }

        // GET /api/games/1
        public IHttpActionResult GetGame(int id)
        {
            var game = _context.Games.SingleOrDefault(g => g.Id == id);

            if (game == null)
                return NotFound();

            return Ok(Mapper.Map<Game, GamesDto>(game));
        }

        // POST /api/games
        [HttpPost]
        public IHttpActionResult CreateGame(GamesDto gamesDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var game = Mapper.Map<GamesDto, Game>(gamesDto);
            _context.Games.Add(game);
            _context.SaveChanges();

            gamesDto.Id = game.Id;
            return Created(new Uri(Request.RequestUri + "/" + game.Id), gamesDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateGame(GamesDto gamesDto, int id)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var gameInDb = _context.Games.SingleOrDefault(g => g.Id == id);

            if (gameInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            Mapper.Map(gamesDto, gameInDb);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteGame(int id)
        {
            var gameInDb = _context.Games.SingleOrDefault(g => g.Id == id);

            if (gameInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Games.Remove(gameInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
