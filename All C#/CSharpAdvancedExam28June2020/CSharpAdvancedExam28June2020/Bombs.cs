using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvancedExam28June2020
{
    class Bombs
    {
        static void Main(string[] args)
        {
            var queue = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> bombEffects = new Queue<int>(queue);
            Stack<int> bombCasings = new Stack<int>(stack);
            Dictionary<int, string> bombTypes = new Dictionary<int, string>()
            {
                {40, "Datura Bombs" },
                {60, "Cherry Bombs" },
                {120 ,"Smoke Decoy Bombs" }
            };
            Dictionary<string, int> bombsMade = new Dictionary<string, int>()
            {
                {"Cherry Bombs", 0 },
                {"Datura Bombs", 0 },          
                {"Smoke Decoy Bombs", 0 }
            };

            bool areBombsMade = false;
            while ((bombEffects.Count != 0 && bombCasings.Count != 0))
            {
                int currEffect = bombEffects.Peek();
                int currCasing = bombCasings.Pop();
                int elementsSum = currEffect + currCasing;

                if (bombTypes.ContainsKey(elementsSum))
                {
                    bombsMade[bombTypes[elementsSum]]++;
                    bombEffects.Dequeue();
                }
                else
                {
                    currCasing -= 5;
                    bombCasings.Push(currCasing);
                }

                if (bombsMade["Cherry Bombs"] >= 3 && bombsMade["Datura Bombs"] >= 3 && bombsMade["Smoke Decoy Bombs"] >= 3)
                {
                    areBombsMade = true;
                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");                   
                    break;
                }
            }
            if (!areBombsMade)
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEffects.Count != 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEffects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }


            if (bombCasings.Count != 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }

            foreach ((string bomb, int count) in bombsMade)
            {
                Console.WriteLine($"{bomb}: {count}");


            }

            ;
        }
    }
}
