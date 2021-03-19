using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class journey
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            string placeForVacation = "";
            if(season == "summer")
            {
                placeForVacation = "Camp";
            }
            else
            {
                placeForVacation = "Hotel";
            }

            double expenses = 0;
            string destination = "";
            if(budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    expenses = budget * 0.30;
                }
                else
                {
                    expenses = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    expenses = budget * 0.40;
                }
                else
                {
                    expenses = budget * 0.80;
                }
            }
            else
            {
                placeForVacation = "Hotel";
                destination = "Europe";
                expenses = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeForVacation} - {expenses:F2}");

        }
    }
}
