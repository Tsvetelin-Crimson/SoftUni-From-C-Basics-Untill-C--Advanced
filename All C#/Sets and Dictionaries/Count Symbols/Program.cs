using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedDictionary<char, int> characters = new SortedDictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currCh = input[i];
                if (!characters.ContainsKey(currCh))
                {
                    characters[currCh] = 0;
                }

                characters[currCh]++;
            }


            foreach (var item in characters)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
