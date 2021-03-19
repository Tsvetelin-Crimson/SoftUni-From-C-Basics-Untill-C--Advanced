using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    class ski
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine()) -1;
            string typeRoom = Console.ReadLine(), grade = Console.ReadLine();

            double discountPercents = 0;
            double pricePerNight = 0;

            if (typeRoom == "apartment")
            {
                pricePerNight = 25.0;
                if (nights < 10)
                {
                    discountPercents = 30;
                }
                else if (nights >= 10 && nights < 15)
                {
                    discountPercents = 35;
                }
                else
                {
                    discountPercents = 50;
                }
            }
            else if (typeRoom == "president apartment")
            {
                pricePerNight = 35.0;
                if (nights < 10)
                {
                    discountPercents = 10;
                }
                else if (nights >= 10 && nights < 15)
                {
                    discountPercents = 15;
                }
                else
                {
                    discountPercents = 20;
                }
            }
            else
            {
                pricePerNight = 18.00;
            }

            double priceForTrip = (pricePerNight * nights) - ((pricePerNight * nights) * (discountPercents / 100));
            if (grade == "positive")
            {
                priceForTrip = priceForTrip + (priceForTrip * 0.25);
            }
            else
            {
                priceForTrip = priceForTrip - (priceForTrip * 0.10);
            }

            Console.WriteLine($"{priceForTrip:F2}");
        }
    }
}
