using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equall_sums_even_odd_position
{
    class eseop
    {
        static void Main(string[] args)
        {
            string firstNumb = Console.ReadLine(),//works here only
                secondNumb = Console.ReadLine();
            int realFirst = int.Parse(firstNumb),
                realSecond = int.Parse(secondNumb);

            for (int i = realFirst; i <= realSecond; i++)
            {
                firstNumb = i.ToString();
                int oddSum = 0,
                    evenSum = 0;
                for (int j = 1; j <= 5; j += 2)
                {
                    int currentDigit = firstNumb[j];
                    oddSum += currentDigit;
                }
                for (int j = 0; j <= 4; j += 2)
                {
                    int currentDigit = firstNumb[j];
                    evenSum += currentDigit;
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }

            }





        }
    }
}
