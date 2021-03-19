using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    class hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double numberNights = double.Parse(Console.ReadLine());

            double costAppartment = 0, costStudio = 0;

            if ((month == "May" || month == "October") && (numberNights > 7 && numberNights < 14))
            {
                costStudio = numberNights * (50 * 0.95);
            }
            else if ((month == "May" || month == "October") && numberNights > 14)
            {
                costStudio = numberNights * (50.00  * 0.7);
            }
            else if ((month == "June" || month == "September") && numberNights > 14)
            {
                costStudio = numberNights * (75.20 * 0.8);
            }
            else if (month == "May" || month == "October")
            {
                costStudio = numberNights * 50;
            }
            else if (month == "June" || month == "September")
            {
                costStudio = numberNights * 75.20;
            }
            else
            {
                costStudio = numberNights * 76.00;
            }

            double costAppartmentDiscount = 1;
            if (numberNights > 14)
            {
              costAppartmentDiscount = 0.9;
            }
            double costMayOct = 65.0, costJuneSept = 68.7, costJulyDec = 77.0;

            costMayOct *= costAppartmentDiscount;
            costJuneSept *= costAppartmentDiscount;
            costJulyDec *= costAppartmentDiscount;
            if (month == "May" || month == "October")
            {
                costAppartment = numberNights * costMayOct;
            }
            else if (month == "June" || month == "September")
            {
                costAppartment = numberNights * costJuneSept;
            }
            else
            {
                costAppartment = numberNights * costJulyDec;
            }

            

            Console.WriteLine($"Apartment: {costAppartment:F2} lv.");
            Console.WriteLine($"Studio: {costStudio:F2} lv.");


        }
    }
}
