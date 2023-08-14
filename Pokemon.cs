using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        public string Name { get; set; }
        public List<MoveInfo> Moves { get; set; }
        public Pokemon()
    {
    }
     public Pokemon(string name)
    {
        Name = name;
    }
        
    }
}