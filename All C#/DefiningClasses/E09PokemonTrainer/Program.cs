using System;
using System.Collections.Generic;
using System.Linq;

namespace E09PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split();
                string trainerName = tokens[0],
                    pokemonName = tokens[1],
                    pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Pokemon currPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer currTrainer = new Trainer(trainerName);
                    trainers[trainerName] = currTrainer;
                }

                trainers[trainerName].Pokemons.Add(currPokemon);
            }


            while ((input = Console.ReadLine()) != "End")
            {
                foreach ((string trainerName, Trainer trainer) in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == input))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        int pokemonCount = trainer.Pokemons.Count;


                        for (int i = 0; i < pokemonCount; i++)
                        {
                            
                            Pokemon currPokemon = trainer.Pokemons[i];
                            currPokemon.Health -= 10;
                            
                            if (currPokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(currPokemon);
                                i--;
                                pokemonCount--;
                            }
                        }
                    }
                }


            }

            trainers = trainers.OrderByDescending(t => t.Value.NumberOfBadges).ToDictionary(t => t.Key, k => k.Value);

            foreach ((string name, Trainer trainer) in trainers)
            {
                Console.WriteLine($"{name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }





        }
    }
}
