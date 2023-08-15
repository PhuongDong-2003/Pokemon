using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
namespace Pokemon
{
    public interface IPokemonInput
    {
        List<string> ParseArgs(string[] args);
        
     

    }
}