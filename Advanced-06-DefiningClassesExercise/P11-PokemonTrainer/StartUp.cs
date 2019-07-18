namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var trainersList = new List<Trainer>();

            while (true)
            {
                var infoArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (infoArgs[0] == "Tournament")
                {
                    break;
                }

                string trainerName = infoArgs[0];
                Trainer trainer = null;
                if (trainersList.Any(t => t.Name == trainerName))
                {
                    trainer = trainersList.FirstOrDefault(t => t.Name == trainerName);
                }
                else
                {
                    trainer = new Trainer(trainerName);
                    trainersList.Add(trainer);
                }

                string name = infoArgs[1];
                string element = infoArgs[2];
                int health = int.Parse(infoArgs[3]);
                Pokemon pokemon = new Pokemon(name, element, health);
                trainer.AddPokemon(pokemon);
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                foreach (var trainer in trainersList)
                {
                    if (trainer.Pokemons.Any(p=>p.Element == input))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.ReduceAllPokemonsHealth(10);
                    }
                    trainer.RemoveDeadPokemons();
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, trainersList.OrderByDescending(t=>t.Badges)));
        }
    }
}