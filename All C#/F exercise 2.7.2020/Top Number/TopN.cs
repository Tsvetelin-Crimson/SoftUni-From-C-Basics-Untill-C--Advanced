using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Number
{
    class TopN
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintTopNumbersInTheNumber(number);            
        }

        static void PrintTopNumbersInTheNumber(int n)
        {
            for (int i = 1; i < n; i++)
            {
                bool hasOdd = false;
                int sumIntegers = 0;
                int number = i;
                while (number > 0)
                {
                    sumIntegers += number % 10;
                    if ((number % 10) % 2 == 1)
                    {
                        hasOdd = true;
                    }
                    number /= 10;
                }
                if (sumIntegers % 8 == 0 && hasOdd)
                {
                    Console.WriteLine(i);
                }

            }




        }


    }
}
