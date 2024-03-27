using BlazorApp1.Core.Entities;
using BlazorApp1.Core.Interfaces;
using BlazorApp1.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services
{
    public class GameService : IGame
    {
        private readonly DataContext _context;
        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<Game> Add(Game game)
        {
             _context.Games.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task<List<Game>> GetAll()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }
    }
}
