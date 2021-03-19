using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr6
{
    class Mattrix
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine()),
                c = int.Parse(Console.ReadLine()),
                d = int.Parse(Console.ReadLine());

            for (int firstRowFirstNumb = a; firstRowFirstNumb <= b; firstRowFirstNumb++)
            {
                for (int firstRowSecondNumb = a; firstRowSecondNumb <= b; firstRowSecondNumb++)
                {
                    for (int secondRowFirstNumb = c; secondRowFirstNumb <= d; secondRowFirstNumb++)
                    {
                        for (int secondRowSecondNumb = c; secondRowSecondNumb <= d; secondRowSecondNumb++)
                        {
                            if ((firstRowFirstNumb + secondRowSecondNumb) == (firstRowSecondNumb + secondRowFirstNumb) && 
                                (firstRowFirstNumb != firstRowSecondNumb) &&(secondRowFirstNumb != secondRowSecondNumb))
                            {
                                Console.WriteLine($"{firstRowFirstNumb}{firstRowSecondNumb}");
                                Console.WriteLine($"{secondRowFirstNumb}{secondRowSecondNumb}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }

        }
    }
}
