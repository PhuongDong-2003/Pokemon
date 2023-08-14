using System.Diagnostics;

namespace Pokemon;
public class Program
{
    /// <summary>
    /// "mega-punch" "fire-punch" "thunder-punch" "scratch" "swords-dance" "cut" "ddd" "wing-attack" "snore" "mega-kick"
    /// </summary>
    /// <param name="args"></param>
    public static async Task Main(string[] args)
    {
         Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        // string [] test = { "headbutt", "feint-attack"};
        IPokemonIput pokemonInput = new PokemonInput();
        IPokemonSearch pokemonSearch = new PokemonSearch();
        IPokemonPrinter pokemonPrinter= new PokemonPrinter();
        List<string> moveArr = pokemonInput.ParseArgs(args);
        List<Move> moves = await pokemonSearch.GetMoves(moveArr);
        List<string> pokemons = pokemonSearch.GetPokemonFromMoveList(moves);
        pokemonPrinter.PrintRelatedPokemons(pokemons);
        
        stopwatch.Stop();
        double elapsedMinutes = (double)stopwatch.ElapsedMilliseconds / 1000 / 60;
        Console.WriteLine($"Elapsed time: {stopwatch.ElapsedMilliseconds} milliseconds");
        Console.WriteLine($"Elapsed time: {elapsedMinutes} minutes");

    }

}