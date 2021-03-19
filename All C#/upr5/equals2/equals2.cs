using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equals2
{
    class equals2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int firstNumb = int.Parse(Console.ReadLine()),
                secondNumb = int.Parse(Console.ReadLine()),
                previousPair = firstNumb + secondNumb,
                maxDiff = 0;
                

            bool equalPair = true;



            for (int i = 0; i < n - 1; i++)
            {
                firstNumb = int.Parse(Console.ReadLine());
                secondNumb = int.Parse(Console.ReadLine());

                int currentPair = firstNumb + secondNumb;
                if (previousPair != currentPair)
                {
                    equalPair = false;
                    maxDiff = Math.Abs(previousPair - currentPair);                                                                              
                }
                  previousPair = currentPair;
            }
            if (equalPair)
            {
                Console.WriteLine($"Yes, value={previousPair}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }

        }
    }
}
