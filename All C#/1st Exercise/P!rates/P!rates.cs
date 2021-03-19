using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> gold = new Dictionary<string, int>();
            Dictionary<string, int> population = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] inputArgs = input.Split("||");
                string currName = inputArgs[0];
                int currPopulation = int.Parse(inputArgs[1]);
                int currGold = int.Parse(inputArgs[2]);

                if (!population.ContainsKey(currName))
                {
                    population[currName] = 0;
                    gold[currName] = 0;
                }

                population[currName] += currPopulation;
                gold[currName] += currGold;
            }

            ;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split("=>");
                string command = inputArgs[0];

                if (command == "Plunder")
                {
                    string currAttTown = inputArgs[1];
                    int deaths = int.Parse(inputArgs[2]);
                    int takenGold = int.Parse(inputArgs[3]);

                    gold[currAttTown] -= takenGold;
                    population[currAttTown] -= deaths;
                    Console.WriteLine($"{currAttTown} plundered! {takenGold} gold stolen, {deaths} citizens killed.");
                    if (gold[currAttTown] <= 0 || population[currAttTown] <= 0)
                    {
                        gold.Remove(currAttTown);
                        population.Remove(currAttTown);
                        Console.WriteLine($"{currAttTown} has been wiped off the map!");
                    }
                    
                }
                else if(command == "Prosper")
                {
                    string townName = inputArgs[1];
                    int goldAdded = int.Parse(inputArgs[2]);

                    if (goldAdded >= 0)
                    {
                        gold[townName] += goldAdded;
                        Console.WriteLine($"{goldAdded} gold added to the city treasury. {townName} now has {gold[townName]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }
            }

            if (gold.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {gold.Count} wealthy settlements to go to:");
                gold = gold.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
                foreach (var town in gold)
                {
                    string name = town.Key;
                    int currGold = town.Value;
                    int currPopulation = population[name];
                    Console.WriteLine($"{name} -> Population: {currPopulation} citizens, Gold: {currGold} kg");
                }
            }

        }
    }
}
