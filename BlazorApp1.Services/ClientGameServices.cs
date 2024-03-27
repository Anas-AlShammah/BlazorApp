using BlazorApp1.Core.Entities;
using BlazorApp1.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Services
{
    public class ClientGameServices : IGame
    {
        private readonly HttpClient _httpClient;
        public ClientGameServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Game> Add(Game game)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/game", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }

        public Task<List<Game>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
