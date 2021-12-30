using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string[] input = Console.ReadLine().Split();

            while(input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                trainers[trainerName].PokemonCollection.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                input = Console.ReadLine().Split();
            }

            string command = Console.ReadLine();

            while(command != "End")
            {
                if(command == "Fire")
                {
                    foreach(Trainer trainer in trainers.Values)
                    {
                        if (trainer.PokemonCollection.Any(p => p.Element == "Fire"))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            for(int i = 0; i < trainer.PokemonCollection.Count; i++)
                            {
                                trainer.PokemonCollection[i].Health -= 10;
                                if(trainer.PokemonCollection[i].Health <= 0)
                                {
                                    trainer.PokemonCollection.RemoveAt(i);
                                    i--;
                                }

                            }
                        }
                    }
                }
                else if(command == "Water")
                {
                    foreach (Trainer trainer in trainers.Values)
                    {
                        if (trainer.PokemonCollection.Any(p => p.Element == "Water"))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            for (int i = 0; i < trainer.PokemonCollection.Count; i++)
                            {
                                trainer.PokemonCollection[i].Health -= 10;
                                if (trainer.PokemonCollection[i].Health <= 0)
                                {
                                    trainer.PokemonCollection.RemoveAt(i);
                                    i--;
                                }

                            }
                        }
                    }
                }
                else if(command == "Electricity")
                {
                    foreach (Trainer trainer in trainers.Values)
                    {
                        if (trainer.PokemonCollection.Any(p => p.Element == "Electricity"))
                        {
                            trainer.NumberOfBadges++;
                        }
                        else
                        {
                            for (int i = 0; i < trainer.PokemonCollection.Count; i++)
                            {
                                trainer.PokemonCollection[i].Health -= 10;
                                if (trainer.PokemonCollection[i].Health <= 0)
                                {
                                    trainer.PokemonCollection.RemoveAt(i);
                                    i--;
                                }

                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach(var trainer in trainers.Values.OrderByDescending(t => t.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.PokemonCollection.Count}");
            }
        }
    }
}
