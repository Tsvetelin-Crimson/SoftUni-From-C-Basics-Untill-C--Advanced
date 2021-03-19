using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class CardsG
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            
            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                if (firstPlayer[0] == secondPlayer[0])
                {
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPlayer.Remove(secondPlayer[0]);
                }
                else if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                    firstPlayer.Remove(firstPlayer[0]);
                    secondPlayer.Remove(secondPlayer[0]);
                }
                else
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                    secondPlayer.Remove(secondPlayer[0]);
                    firstPlayer.Remove(firstPlayer[0]);
                }
            }

            if (firstPlayer.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }


        }
    }
}
