namespace Pokemon;
public class Program
{
    public static void Main(string[] args)
    {
        string [] test = { "headbutt", "feint-attack"};
        IPokemonIput pokemonInput = new PokemonInput();
        IPokemonSearch pokemonSearch = new PokemonSearch();
        IPokemonPrinter pokemonPrinter= new PokemonPrinter();
        List<string> moveArr = pokemonInput.ParseArgs(test);
        List<Move> moves = pokemonSearch.GetMoves(moveArr);
        List<string> pokemons = pokemonSearch.GetPokemonFromMoveList(moves);
        pokemonPrinter.PrintRelatedPokemons(pokemons);
        


    }

}