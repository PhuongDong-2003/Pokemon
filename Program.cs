namespace Pokemon;
public class Program
{
    public static void Main(string[] args)
    {
        IPokemonIput pokemonInput = new PokemonInput();
        IPokemonSearch pokemonSearch = new PokemonSearch();

        List<string> moveArr = pokemonInput.ParseArgs(args);
        List<Move> moves = pokemonSearch.GetMoves(moveArr);
        List<string> pokemons = pokemonSearch.GetPokemonFromMoveList(moves);

        foreach (string pokemon in pokemons)
        {
            Console.WriteLine(pokemon);
        }

    }

}