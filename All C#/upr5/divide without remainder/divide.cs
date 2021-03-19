using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divide_without_remainder
{
    class divide
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double c1 = 0,
                c2 = 0,
                c3 = 0;

            double p1 = 0,
                p2 = 0,
                p3 = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumb = int.Parse(Console.ReadLine());

                if (currentNumb % 2 == 0)
                {
                    c1++;
                }
                if (currentNumb % 3 == 0)
                {
                    c2++;
                }
                if (currentNumb % 4 == 0)
                {
                    c3++;
                }

            }

            p1 = (c1 / n) * 100;
            p2 = (c2 / n) * 100;
            p3 = (c3 / n) * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
        }
    }
}
