using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dummyExam
{
    class firstTask
    {
        static void Main(string[] args)
        {
            double foodMoney = int.Parse(Console.ReadLine()),
                souveniersMoney = int.Parse(Console.ReadLine()),
                hotelPrice = int.Parse(Console.ReadLine()),
                priceForFuelPerL = 1.85,
                distance = 420,
                carFuelUsePer100KM = 7,
                day = 3;
            double endFuel = distance / 100 * carFuelUsePer100KM,
                endFuelPrice = endFuel * priceForFuelPerL;

            double priceFoodSouveniers = day * souveniersMoney + day * foodMoney;
            double day1PriceHotel = hotelPrice * 0.9,
                day2PriceHotel = hotelPrice * 0.85,
                day3PriceHotel = hotelPrice * 0.80;

            double endPrice = endFuelPrice + priceFoodSouveniers + day1PriceHotel + day2PriceHotel + day3PriceHotel;

            Console.WriteLine($"Money needed: {endPrice:F2}");


        }
    }
}
