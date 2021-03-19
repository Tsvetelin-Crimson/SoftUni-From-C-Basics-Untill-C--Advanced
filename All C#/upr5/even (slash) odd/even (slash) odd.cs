using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even__slash__odd
{
    class Program
    {
        static void Main(string[] args)
        {
            double numbOfNumbers = int.Parse(Console.ReadLine()),
                oddSum = 0,
                oddMin = int.MaxValue,
                oddMax = int.MinValue,
                evenSum = 0,
                evenMin = int.MaxValue,
                evenMax = int.MinValue;

            for (int i = 1; i <= numbOfNumbers; i++)
            {
                double newNumbs = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += newNumbs;
                    if (newNumbs > evenMax)
                    {
                        evenMax = newNumbs;
                    }
                    if(newNumbs < evenMin)
                    {
                        evenMin = newNumbs;
                    }    
                }
                else
                {
                    oddSum += newNumbs;
                    if (newNumbs > oddMax)
                    {
                        oddMax = newNumbs;
                    }
                    if (newNumbs < oddMin)
                    {
                        oddMin = newNumbs;
                    }
                }

            }

            Console.WriteLine($"OddSum={oddSum:F2},");
            if (oddMin != int.MaxValue)
            {
                Console.WriteLine($"OddMin={oddMin:F2},");
            }
            else
            {
                Console.WriteLine($"OddMin=No,");
            }
            if (oddMax != int.MinValue)
            {
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            else
            {
                Console.WriteLine($"OddMax=No,");
            }
            Console.WriteLine($"EvenSum={evenSum:F2},");
            if (evenMin != int.MaxValue)
            {
                Console.WriteLine($"EvenMin={evenMin:F2},");
            }
            else
            {
                Console.WriteLine($"EvenMin=No,");
            }
            if (evenMax != int.MinValue)
            {
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
            else
            {
                Console.WriteLine($"EvenMax=No");
            }

        }
    }
}
