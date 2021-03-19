using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class histogram
    {
        static void Main(string[] args)
        {
            double n = int.Parse(Console.ReadLine());
            double c1 = 0,
                c2 = 0,
                c3 = 0,
                c4 = 0,
                c5 = 0;

            double p1 = 0,
                p2 = 0,
                p3 = 0,
                p4 = 0,
                p5=0;
                


            for (int i = 0; i < n; i++)
            {
                int currentNumb = int.Parse(Console.ReadLine());

                if (currentNumb < 200)
                {
                    c1++;
                }
                else if (currentNumb < 400)
                {
                    c2++;
                }
                else if (currentNumb < 600)
                {
                    c3++;
                }
                else if (currentNumb < 800)
                {
                    c4++;
                }
                else
                {
                    c5++;
                }
            }

            p1 = (c1 / n) * 100;
            p2 = (c2 / n) * 100;
            p3 = (c3 / n) * 100;
            p4 = (c4 / n) * 100;
            p5 = (c5 / n) * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");


        }
    }
}
