using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceSides = new Dictionary<string, List<string>>();
            
            
            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] tokensOfInput = input.Split(new string[] {" | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string command = tokensOfInput[1];

                if (input.Contains("|"))
                {
                    string side = tokensOfInput[0],
                        user = tokensOfInput[1];
                    AddUserToSide(forceSides, side, user);

                }
                else if (input.Contains("->"))
                {
                    string side = tokensOfInput[1],
                        user = tokensOfInput[0];
                    if (!forceSides.ContainsKey(side))
                    {
                        forceSides[side] = new List<string>();
                    }

                    foreach (var item in forceSides)
                    {
                        if (item.Value.Contains(user))
                        {
                            item.Value.Remove(user);
                        }                        
                    }
                    forceSides[side].Add(user);
                    Console.WriteLine($"{user} joins the {side} side!");
                }

            }

            forceSides = forceSides
                .Where(l => l.Value.Count > 0)
                .OrderByDescending(a => a.Value.Count)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var item in forceSides)
            {
                List<string> currNames = item.Value.OrderBy(u => u).ToList();
                Console.WriteLine($"Side: {item.Key}, Members: {item.Value.Count()}\n! {string.Join("\n! ", currNames)}");
                
            }

        }

        private static void AddUserToSide(Dictionary<string, List<string>> forceSides, string side, string user)
        {
            if (!forceSides.ContainsKey(side))
            {
                forceSides[side] = new List<string>();
            }

            if (!forceSides.Values.Any(l => l.Contains(user)))
            {
                forceSides[side].Add(user);
            }
        }
    }
}
