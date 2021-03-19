using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr8
{
    class record
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double swimmingTimeInSecondsFor1Meter = double.Parse(Console.ReadLine());

            double secondsSwamNoCurrent = distanceInMeters * swimmingTimeInSecondsFor1Meter;
            double addedTimeDueToCurrent = Math.Floor(distanceInMeters / 15) * 12.5;

            double fullTimeSwam = secondsSwamNoCurrent + addedTimeDueToCurrent;

            if (fullTimeSwam < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {fullTimeSwam:F2} seconds.");
            }
            else
            {
                double difference = fullTimeSwam - record;
                Console.WriteLine($"No, he failed! He was {difference:F2} seconds slower.");
            }
        }
    }
}
