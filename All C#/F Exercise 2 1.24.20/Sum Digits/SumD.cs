using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits
{
    class SumD
    {
        static void Main(string[] args)
        {
            int sumMyDigits = int.Parse(Console.ReadLine()),
                sum = 0;

            while (sumMyDigits != 0)
            {
                sum += sumMyDigits  % 10;
                sumMyDigits /= 10;


            }
            Console.WriteLine(sum);



        }
    }
}
