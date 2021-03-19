using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre_Tickets
{
    class Tickets
    {
        static void Main(string[] args)
        {
            string film;

            double studentTickets = 0,
                standardTickets = 0,
                kidTickets = 0,
                totalTickets = 0;


            while ((film= Console.ReadLine()) != "Finish")
            {
                double spaceInTheatre = int.Parse(Console.ReadLine()),
                    currentFilmTickets = 0,
                    spaceLeftPercentage = 0;
                
                for (int i = 0; i < spaceInTheatre; i++)
                {
                    string ticket = Console.ReadLine();
                    if (ticket == "standard")
                    {
                        standardTickets++;
                        totalTickets++;
                        currentFilmTickets++;
                    }
                    else if (ticket == "student")
                    {
                        studentTickets++;
                        totalTickets++;
                        currentFilmTickets++;
                    }
                    else if (ticket == "kid")
                    {
                        kidTickets++;
                        totalTickets++;
                        currentFilmTickets++;
                    }
                    else if (ticket == "End")
                    {
                        break;
                    }
                }
                spaceLeftPercentage = (currentFilmTickets / spaceInTheatre) * 100;
                Console.WriteLine($"{film} - {spaceLeftPercentage:F2}% full.");
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{(studentTickets / totalTickets)* 100:F2}% student tickets.");
            Console.WriteLine($"{(standardTickets / totalTickets) * 100:F2}% standard tickets.");
            Console.WriteLine($"{(kidTickets / totalTickets) * 100:F2}% kids tickets.");

        }
    }
}
