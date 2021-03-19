using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat
{
    class boat
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishermen = int.Parse(Console.ReadLine());



            double loan = 0;
            switch (season)
            {
                case "Spring":
                    loan = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    loan = 4200;
                    break;
                case "Winter":
                    loan = 2600;
                    break;
            }

            if (numberOfFishermen <= 6)
            {
                loan *= 0.90;
            }
            else if (numberOfFishermen <= 11)
            {
                loan *= 0.85;
            }
            else
            {
                loan *= 0.75;
            }

            if (numberOfFishermen % 2 == 0 && !(season == "Autumn"))
            {
                loan *= 0.95;
            }

            if(budget >= loan)
            {
                budget = budget - loan;
                Console.WriteLine($"Yes! You have {budget:F2} leva left.");
            }
            else
            {
                budget = Math.Abs(budget - loan);
                Console.WriteLine($"Not enough money! You need {budget:F2} leva.");
            }
        }
    }
}
