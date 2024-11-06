using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using MahjongFingertips.Models;

namespace MahjongFingertips.Services
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();
            _client.BaseAddress = new System.Uri("http://localhost:8080/");
        }

        public async Task<List<Jogador>> ObterJogadoresAsync()
        {
            return await _client.GetFromJsonAsync<List<Jogador>>("jogadores") ?? new List<Jogador>();
        }

        public async Task<List<Partida>> ObterPartidasAsync()
        {
            return await _client.GetFromJsonAsync<List<Partida>>("partidas") ?? new List<Partida>();
        }
    }
}
