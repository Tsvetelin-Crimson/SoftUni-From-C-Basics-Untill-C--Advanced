using System;
using System.Text.RegularExpressions;

namespace Extract_Emails
{
    class ExtractE
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patern = @"(?<=\s|^)(?<user>[A-Za-z0-9]([-._]?[A-Za-z0-9])*)@(?<host>[A-Za-z](\-?[A-Za-z])*(\.[A-Za-z](\-?[A-Za-z])*)+)";
            MatchCollection matches = Regex.Matches(text, patern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }

        }
    }
}
