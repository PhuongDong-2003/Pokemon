using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using System.Text.Json;

namespace Pokemon
{
   
    public class PokemonSearch : IPokemonSearch
    {
        public List<Move> GetMoves(List<string> moveNames)
        {
           List<Move> moves = new List<Move>();

        foreach (string moveName in moveNames)
        {
            var client = new RestClient(moveName);
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
              var move = JsonSerializer.Deserialize<Move>(response.Content);
                moves.Add(move);
            }
        }

        return moves;
        }

        public List<string> GetPokemonFromMoveList(List<Move> moves)
        {
            List<string> pokemons = new List<string>();

        foreach (Move move in moves)
        {
            pokemons.Add($"Pokemon related to {move.Name}");
        }

        return pokemons;
        }
    }
}