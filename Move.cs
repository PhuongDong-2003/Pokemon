using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Move
    {
        public class PokemonLearn
        {
            public string name { get; set; }
        }
        public string name { get; set; }

        public List<PokemonLearn> learned_by_pokemon { get; set; } 

        [JsonPropertyName("accuracy")]
        public int? Accuracy { get; set; }
         
    }
}