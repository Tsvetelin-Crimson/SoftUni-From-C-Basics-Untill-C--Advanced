using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class PokeM
    {
        static void Main(string[] args)
        {
            // look at this again some time
            int power = int.Parse(Console.ReadLine()),
                distance = int.Parse(Console.ReadLine()),
                exhaustiomFactor = int.Parse(Console.ReadLine()),
                pokes = 0;
            double halfInitialPower = power / 2.0; 
                
            while (power >= distance) // = is required likely
            {
                power -= distance;
                pokes++;
                if (power == halfInitialPower && exhaustiomFactor != 0)
                {
                    power /= exhaustiomFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(pokes);

        }
    }
}
