using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PokemonInput : IPokemonIput
    {
        public List<string> ParseArgs(string[] args)
        {
                 List<string> moveList = new List<string>();
            foreach (string arg in args)
            {
                moveList.Add(arg);
            }
            return moveList;
        
        }
    }
}