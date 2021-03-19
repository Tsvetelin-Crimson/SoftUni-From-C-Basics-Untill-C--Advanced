using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr3
{
    class bonustime
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double extraPoints = 0;

            if (points <= 100)
            {
                extraPoints = 5;
            }
            else if (points > 1000)
            {
                extraPoints = points * 0.10;

            }
            else
            {
                extraPoints = points * 0.20;
            }

            if (points % 10 == 5)
            {
                extraPoints = extraPoints + 2;
            }
            else if (points % 2 ==0)
            {
                extraPoints = extraPoints + 1;
            }

            double totalPoints = extraPoints + points;

            Console.WriteLine($"{extraPoints}");
            Console.WriteLine($"{totalPoints}");

        }
    }
}
