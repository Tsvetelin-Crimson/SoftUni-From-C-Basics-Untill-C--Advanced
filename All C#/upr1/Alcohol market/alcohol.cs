using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alcohol_market
{
    class alcohol
    {
        static void Main(string[] args)
        {
            double whiskeyCost = double.Parse(Console.ReadLine());
            double beer = double.Parse(Console.ReadLine());
            double wine = double.Parse(Console.ReadLine());
            double alcX = double.Parse(Console.ReadLine());
            double whiskey = double.Parse(Console.ReadLine());

            double alcXCost = whiskeyCost / 2;
            double wineCost = alcXCost - (0.4 * alcXCost);
            double beerCost = alcXCost - (0.8 * alcXCost);

            double alcXOCost = alcX * alcXCost;
            double wineOCost = wine * wineCost;
            double beerOCost = beer * beerCost;
            double whiskeyOCost = whiskey * whiskeyCost;

            double oCost = alcXOCost + wineOCost + beerOCost + whiskeyOCost;

            Console.WriteLine($"{oCost:F2}");

        }
    }
}
