using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
namespace Pokemon
{
    public interface IPokemonSearch
    {
       Task<List<Move>> GetMoves(List<string> moveNames);
        List<string> GetPokemonFromMoveList(List<Move> moves);
    }
}