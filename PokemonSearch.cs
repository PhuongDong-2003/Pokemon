using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text.Json;
using System.Net.Http;


namespace Pokemon
{

    public class PokemonSearch : IPokemonSearch
    {
        private const string ApiBaseUrl = "https://pokeapi.co/api/v2/move/";

        public async Task<List<Move>> GetMoves(List<string> moveNames)
        {

            var moveTasks = new List<Task<Move>>();

            foreach (string moveName in moveNames)
            {
                var moveTask = GetMoveByName(moveName);
                moveTasks.Add(moveTask);
            }

            var moves = await Task.WhenAll(moveTasks);

            return moves.Where(x => x is not null).ToList();
        }

        private async Task<Move> GetMoveByName(string moveName)
        {
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(ApiBaseUrl + "" + moveName);
            var strContent = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                Move move = JsonSerializer.Deserialize<Move>(strContent);
                Console.WriteLine($"Move '{moveName}' find.");
                return move;
            }
            else
            {
                Console.WriteLine($"Move '{moveName}' not found.");
                return null;
            }

        }

        public List<string> GetPokemonFromMoveList(List<Move> moves)
        {
            List<string> relatedPokemon = new List<string>();
            List<List<string>> movesByPokemon = new List<List<string>>();
            foreach (Move move in moves)
            {
                var l = move.learned_by_pokemon.Select(x => x.name).ToList();
                movesByPokemon.Add(l);
            }
            var a = movesByPokemon.First();

            foreach (List<string> b in movesByPokemon)
            {
                a = a.Intersect(b).ToList();
            }
            return a;
        }





    }
}