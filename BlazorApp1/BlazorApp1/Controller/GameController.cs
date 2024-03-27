using BlazorApp1.Core.Entities;
using BlazorApp1.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGame _gameService;
        public GameController(IGame gameService)
        {
            _gameService = gameService;
        }
        [HttpPost]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            var games = await _gameService.Add(game);
            return Ok(games);
        }

    }
}
