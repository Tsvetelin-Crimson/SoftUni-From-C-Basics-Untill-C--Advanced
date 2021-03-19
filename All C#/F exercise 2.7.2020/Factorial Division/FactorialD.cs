using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Division
{
    class FactorialD
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine()),
                secondNum = double.Parse(Console.ReadLine());

            double firstFact = CalcFactFirst(firstNum),
                secondFact = CalcFactSecond(secondNum);

            double output = firstFact / secondFact;

            Console.WriteLine($"{output:F2}");

        }
       


        static double CalcFactFirst(double n)
        {
            double factorial = 1;

            for (double i = n; i > 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
        static double CalcFactSecond(double n)
        {
            double factorial = 1;

            for (double i = n; i > 1; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}