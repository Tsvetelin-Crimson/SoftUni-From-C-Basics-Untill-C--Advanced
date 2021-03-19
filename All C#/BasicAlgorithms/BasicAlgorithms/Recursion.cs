using System;
using System.Linq;

namespace BasicAlgorithms
{
    class Recursion
    {
        static void Main(string[] args)
        {
            var numberOfFactorial = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(numberOfFactorial));            
        }

        private static int Factorial(int number)
        {
            int sum = 1;
            if (number != 0)
            {
                sum = number * Factorial(--number);
            }         
            return sum;
        }
    }
}
