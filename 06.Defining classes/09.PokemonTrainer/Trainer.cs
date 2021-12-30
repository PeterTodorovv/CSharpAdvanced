using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    class Trainer
    {
        public string Name { set; get; }
        public int NumberOfBadges { set; get; }
        public List<Pokemon> PokemonCollection { set; get; }

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.PokemonCollection = new List<Pokemon>();
        }
    }
}
