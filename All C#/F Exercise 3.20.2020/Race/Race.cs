using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Race
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();

            List<string> validNames = Console.ReadLine().Split(", " ,StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < validNames.Count; i++)
            {
                scores[validNames[i]] = 0;
            }
            string namePatern = @"[A-Za-z]";
            string distancePatern = @"\d";

            string input;
            while ((input = Console.ReadLine()) != "end of race")
            {
                MatchCollection nameMatches = Regex.Matches(input, namePatern);
                MatchCollection distanceMatches = Regex.Matches(input, distancePatern);

                StringBuilder sb = new StringBuilder();
                GetName(nameMatches, sb);
                string name = sb.ToString();
                //Console.WriteLine(name);
                if (scores.ContainsKey(name))
                {
                    int sum = 0;
                    sum = GetSum(distanceMatches, sum);
                    scores[name] += sum;
                }
            }
            scores = scores.OrderBy(a => a.Value).ThenBy(a => a.Key).Skip(scores.Count - 3).Reverse().ToDictionary(a => a.Key, b => b.Value);
            int place = 1;
            foreach (var item in scores)
            {
                
                if (place == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    place++;
                }
                else if (place == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    place++;
                }
                else if (place == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");

                }

            }
        }

        private static int GetSum(MatchCollection distanceMatches, int sum)
        {
            foreach (Match digit in distanceMatches)
            {
                sum += int.Parse(digit.ToString());
            }

            return sum;
        }

        private static void GetName(MatchCollection nameMatches, StringBuilder sb)
        {
            foreach (Match match in nameMatches)
            {
                sb.Append(match);
            }
        }
    }
}
