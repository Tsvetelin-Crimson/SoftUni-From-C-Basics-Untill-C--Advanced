using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strong_Number
{
    class StrongN
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int tempInput = input,
                sum = 0;
                

            while (tempInput > 0)
            {
                int digit = 0,
                fact = 1;
                digit = tempInput % 10;
                tempInput = tempInput / 10;

                for (int i = 1; i <= digit; i++)
                {
                    fact *= i;
                }

                sum += fact;
            }

            if (sum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
