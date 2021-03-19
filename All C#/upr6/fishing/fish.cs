using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fishing
{
    class fish
    {
        static void Main(string[] args)
        {
            int quota = int.Parse(Console.ReadLine()),
                fishCaught = 0;
            double expenses = 0,
                profit = 0;
            string fish = "";

            while ( fishCaught != quota && (fish = Console.ReadLine()) != "Stop")
            {
                double fishKG = double.Parse(Console.ReadLine()),
                     ASCIIQuantity = 0;

                for (int currentLetter = 0; currentLetter < fish.Length; currentLetter++)
                {
                    ASCIIQuantity += fish[currentLetter];
                }
                fishCaught++;
                if (fishCaught % 3 != 0)
                {
                    expenses += (ASCIIQuantity / fishKG);
                }
                else
                {
                    profit += (ASCIIQuantity / fishKG);
                }

            }
            if (fishCaught == quota)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }

            if (expenses > profit)
            {
                Console.WriteLine($"Lyubo lost {Math.Abs(profit - expenses):F2} leva today.");
            }
            else
            {
                Console.WriteLine($"Lyubo's profit from {fishCaught} fishes is {profit - expenses:F2} leva.");
            }

        }
    }
}
