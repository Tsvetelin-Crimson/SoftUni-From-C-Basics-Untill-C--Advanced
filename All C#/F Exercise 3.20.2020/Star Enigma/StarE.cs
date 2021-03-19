using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class StarE
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string patern = @"@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<attType>A|D)![^@\-!:>]*->(?<soldiers>\d+)";
            List<string> destroyedPlanets = new List<string>();
            List<string> attackedPlanets = new List<string>();


            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                int key = GetKey(message);              
                string decryptedMessage = GetDecrypedMessage(message, key);
                Match match = Regex.Match(decryptedMessage, patern);

                if (match.Success)
                {
                    string planetName = match.Groups["planet"].Value;
                    string attType = match.Groups["attType"].Value;

                    if (attType == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
            attackedPlanets = attackedPlanets.OrderBy(a => a).ToList();
            destroyedPlanets = destroyedPlanets.OrderBy(a => a).ToList();

            PrintMessage(attackedPlanets, "Attacked");
            PrintMessage(destroyedPlanets, "Destroyed");

        }

        private static void PrintMessage(List<string> planets, string attType)
        {
            Console.WriteLine($"{attType} planets: {planets.Count}");
            foreach (var planet in planets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
        private static string GetDecrypedMessage(string message, int key)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < message.Length; j++)
            {
                char currChar = (char)(message[j] - key);
                sb.Append(currChar);
            }
            return sb.ToString();
        }

        private static int GetKey(string message)
        {
            char[] keyChars = new char[] { 's', 't', 'a', 'r' };
            message = message.ToLower();
            int key = 0;
            for (int i = 0; i < message.Length; i++)
            {
                char currChar = message[i];
                if (keyChars.Contains(currChar))
                {
                    key++;
                }
            }

            return key;
        }
    }
}
