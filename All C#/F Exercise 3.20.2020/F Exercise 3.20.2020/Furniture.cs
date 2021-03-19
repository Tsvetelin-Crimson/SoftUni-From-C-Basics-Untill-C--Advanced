using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace F_Exercise_3._20._2020
{
    class Furniture
    {
        static void Main(string[] args)
        {
            List<string> furniture = new List<string>();

            string patern = @">>(?<item>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";
            decimal sum = 0.0m;
            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match currMatch = Regex.Match(input, patern);

                if (currMatch.Success)
                {
                    string item = currMatch.Groups["item"].Value;
                    decimal price = decimal.Parse(currMatch.Groups["price"].Value);
                    long qtty = long.Parse(currMatch.Groups["quantity"].Value);

                    furniture.Add(item);
                    sum += price * qtty;
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (string item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {sum:F2}");
        }
    }
}
