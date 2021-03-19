using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");

                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                string[] clothes = input[1].Split(',');
                for (int j = 0; j < clothes.Length; j++)
                {
                    string currClothing = clothes[j];

                    if (!wardrobe[color].ContainsKey(currClothing))
                    {
                        wardrobe[color][currClothing] = 0;
                    }

                    wardrobe[color][currClothing]++;
                }
            }
            string[] requiredClothing = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string requiredColor = requiredClothing[0];
            string clothing = requiredClothing[1];
            foreach (var colors in wardrobe)
            {
                Console.WriteLine($"{colors.Key} clothes:");
                if (colors.Key == requiredColor)
                {
                    foreach (var item in colors.Value)
                    {
                        if (item.Key == clothing)
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {item.Key} - {item.Value}");
                        }
                    }
                }
                else
                {
                    foreach (var item in colors.Value)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }


            }

        }
    }
}
