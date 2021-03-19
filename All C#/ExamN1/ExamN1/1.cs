using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamN1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketGoing = double.Parse(Console.ReadLine()),
                ticketBack = double.Parse(Console.ReadLine()),
                ticketMatch = double.Parse(Console.ReadLine());
            int matches = int.Parse(Console.ReadLine()),
                discount = int.Parse(Console.ReadLine());

            double planeTicketPrice = 6 * (ticketGoing + ticketBack),
                discountPrice = planeTicketPrice * ((double)discount / 100),
                endPlanePrice = planeTicketPrice - discountPrice,
                matchesPrice = 6 * (matches * ticketMatch),
                endSum = matchesPrice + endPlanePrice,
                pricePerPerson = endSum / 6;
           


            Console.WriteLine($"Total sum: {endSum:F2} lv.");
            Console.WriteLine($"Each friend has to pay {pricePerPerson:F2} lv.");






        }
    }
}
