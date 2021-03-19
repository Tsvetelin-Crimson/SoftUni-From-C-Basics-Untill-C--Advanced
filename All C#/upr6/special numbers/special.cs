using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace special_numbers
{
    class special
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine()),
                
                end = 9999;

            for (int start = 1111; start <= 9999; start++)
            {
                int substitution = start,
                    firstDigit = start / 1000,
                    secondDigit = (start / 100) % 10,
                    thirdDigit = (start / 10) % 100 % 10,
                    fourthDidgit = start % 10;
                if (firstDigit != 0 && secondDigit != 0 && thirdDigit != 0 && fourthDidgit != 0)
                {
                if (input % firstDigit == 0 && input % secondDigit == 0 && input % thirdDigit == 0 && input % fourthDidgit == 0)
                {
                    Console.Write($"{start} ");
                }
                }
                

            }



        }
    }
}
