using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace halfsum
{
    class halfsum
    {
        static void Main(string[] args)
        {
            int numbOfNumbs = int.Parse(Console.ReadLine()),
                biggestNumb = 0,
                sum = 0;
            
            for (int i = 0; i < numbOfNumbs; i++)
            {
                int newNumbs = int.Parse(Console.ReadLine());
                if (newNumbs > biggestNumb)
                {
                    biggestNumb = newNumbs;
                    sum += newNumbs;
                }
                else
                {
                    sum = sum + newNumbs;
                }
            }
            sum -= biggestNumb;
            if (biggestNumb == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestNumb}");
            }
            else
            {
                int diff = Math.Abs(biggestNumb - sum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }

        }
    }
}
