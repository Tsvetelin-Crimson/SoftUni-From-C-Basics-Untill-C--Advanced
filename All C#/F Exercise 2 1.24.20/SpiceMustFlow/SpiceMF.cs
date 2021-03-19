using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiceMustFlow
{
    class SpiceMF
    {
        static void Main(string[] args)
        {
            long startingYield = long.Parse(Console.ReadLine()),
                workersCut = 26,
                daysWorked = 0,
                endSpice = 0;


            while (startingYield >= 100)
            {
                if (endSpice + startingYield - workersCut > 0)
                {
                   endSpice += startingYield - workersCut;
                }
                else
                {
                    endSpice = 0;
                }
                daysWorked++;
                startingYield -= 10;
            }
            Console.WriteLine(daysWorked);
            if (daysWorked == 0)
            {
                Console.WriteLine(endSpice);
            }
            else
            Console.WriteLine(endSpice - workersCut);
        }
    }
}
