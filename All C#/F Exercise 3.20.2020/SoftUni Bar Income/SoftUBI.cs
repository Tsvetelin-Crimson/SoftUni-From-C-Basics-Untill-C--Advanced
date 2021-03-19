using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class SoftUBI
    {
        static void Main(string[] args)
        {

            string patern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";
            decimal profit = 0.0m;
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, patern);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    long count = long.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    profit += count * price;
                    Console.WriteLine($"{name}: {product} - {count * price:F2}");
                }
            }
            Console.WriteLine($"Total income: {profit:F2}");
        }
    }
}
