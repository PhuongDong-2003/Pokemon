using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace Pokemon
{

    public class PokemonSearch : IPokemonSearch
    {
        private const string ApiBaseUrl = "https://pokeapi.co/api/v2/move/";

        public List<Move> GetMoves(List<string> moveNames)
        {
            List<Move> moves = new List<Move>();

            foreach (string moveName in moveNames)
            {
                Move move = GetMoveByName(moveName).Result;
                if (move != null)
                {
                    moves.Add(move);
                }
            }

            return moves;
        }

        public List<string> GetPokemonFromMoveList(List<Move> moves)
        {
            List<string> relatedPokemon = new List<string>();

            foreach (Move move in moves)
            {
                if (move.learned_by_pokemon != null)
                {
                    foreach (Move.PokemonLearn pokemonLearn in move.learned_by_pokemon)
                    {
                        relatedPokemon.Add(pokemonLearn.name);
                    }
                }
            }

            return relatedPokemon;
        }

        private async Task<Move> GetMoveByName(string moveName)
        {
            HttpClient httpClient = new HttpClient();

            var response = await httpClient.GetAsync(ApiBaseUrl + "" + moveName);
            var strContent = await response.Content.ReadAsStringAsync();
            Move move = JsonSerializer.Deserialize<Move>(strContent);
            return move;
        }



    }
}