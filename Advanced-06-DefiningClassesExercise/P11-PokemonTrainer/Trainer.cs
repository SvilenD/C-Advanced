﻿namespace DefiningClasses
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            this.Badges = 0;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; private set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; } 

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        public void ReduceAllPokemonsHealth(int value)
        {
            Pokemons.Select(p => p.Health -= value);
        }

        public void RemoveDeadPokemons()
        {
            Pokemons.RemoveAll(p => p.Health <= 0);
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
        }
    }
}