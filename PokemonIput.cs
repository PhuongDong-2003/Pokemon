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
            if(args.Length < 2)
            {
                Console.WriteLine("Vui lòng nhập ít nhất một chiêu thức.");
            }

            List<string> moveList = new List<string>();
            for (int i = 0; i < args.Length; i++)
            {
                moveList.Add(args[i]);
            }

            return moveList;
        }
    }

}