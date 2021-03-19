using System;
using System.Collections.Generic;

namespace Count_chars_in_a_string
{
    class CountCIAS
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, uint> chars = new Dictionary<char, uint>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                }
                else if (chars.ContainsKey(input[i]))
                {
                    chars[input[i]]++;
                }
                else
                {
                    chars.Add(input[i], 1); //chars[input[i]] = 1;
                }
            }

            foreach (var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
