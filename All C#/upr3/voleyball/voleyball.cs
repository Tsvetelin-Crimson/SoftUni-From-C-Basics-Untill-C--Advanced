using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voleyball
{
    class voleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double holiday = double.Parse(Console.ReadLine()),
                weekendsInHometown = double.Parse(Console.ReadLine()),
                weekends = 48;

            double daysLeft = weekends - weekendsInHometown,
                satGames = daysLeft * 3 / 4,
                holidayGames = holiday * 2 / 3;

            double combinedGamesPlayed = satGames + holidayGames + weekendsInHometown;

            if (year == "leap")
            {
                combinedGamesPlayed = combinedGamesPlayed * 1.15;
            }

            Console.WriteLine(Math.Floor(combinedGamesPlayed));


        }
    }
}
