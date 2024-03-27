using BlazorApp1.Core.Entities;

namespace BlazorApp1.Core.Interfaces
{
    public interface IGame
    {
        Task<List<Game>> GetAll();
        Task<Game> Add(Game game);
    }
}
