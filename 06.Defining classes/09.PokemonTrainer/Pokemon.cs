using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    class Pokemon
    {
        public string Name { set; get; }
        public string Element { set; get; }
        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }
    }
}
