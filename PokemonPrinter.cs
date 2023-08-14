using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon
{
    public class PokemonPrinter : IPokemonPrinter
    {
        public  void PrintRelatedPokemons(List<string> relatedPokemons)
        {
            if (relatedPokemons.Count > 0)
            {
                Console.WriteLine($"Danh sách Pokémon có liên quan đến chiêu thức :");
                foreach (string pokemon in relatedPokemons)
                {
                    Console.WriteLine(pokemon);
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy Pokémon có liên quan.");
            }
        }
    }
}