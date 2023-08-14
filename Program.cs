using System.Diagnostics;

namespace Pokemon;
public class Program
{
    /// <summary>
    /// "mega-punch" "fire-punch" "thunder-punch" "scratch" "swords-dance" "cut" "ddd" "wing-attack" "snore" "mega-kick"
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
         Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        // string [] test = { "headbutt", "feint-attack"};
        IPokemonIput pokemonInput = new PokemonInput();
        IPokemonSearch pokemonSearch = new PokemonSearch();
        IPokemonPrinter pokemonPrinter= new PokemonPrinter();
        List<string> moveArr = pokemonInput.ParseArgs(args);
        List<Move> moves = pokemonSearch.GetMoves(moveArr);
        List<string> pokemons = pokemonSearch.GetPokemonFromMoveList(moves);
        pokemonPrinter.PrintRelatedPokemons(pokemons);
        
         stopwatch.Stop();
        Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} milliseconds");

    }

}