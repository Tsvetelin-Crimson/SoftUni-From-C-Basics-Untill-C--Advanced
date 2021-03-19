using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class t6
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());




            for (int currentLocation = 0; currentLocation < locations; currentLocation++)
            {
                double expectedAverageGain = double.Parse(Console.ReadLine()),
                    TotalGain = 0,
                    averageGain = 0;

                int daysForMining = int.Parse(Console.ReadLine());


                for (int currentDay = 0; currentDay < daysForMining; currentDay++)
                {
                    double gain = double.Parse(Console.ReadLine());
                    TotalGain += gain;
                }

                averageGain = TotalGain / daysForMining;

                if (averageGain >= expectedAverageGain)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averageGain:F2}.");
                }
                else
                {
                    expectedAverageGain -= averageGain;
                    Console.WriteLine($"You need {expectedAverageGain:F2} gold.");
                }
            }
        }
    }
}
