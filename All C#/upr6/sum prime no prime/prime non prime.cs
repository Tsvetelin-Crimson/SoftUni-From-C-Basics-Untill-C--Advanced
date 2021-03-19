using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_prime_no_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0,
                nonPrimeSum = 0;
            while (input != "stop")
            {
                int inputNumb = int.Parse(input);

                if (inputNumb < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else if (inputNumb % 2 == 0 && inputNumb != 2)
                {
                    nonPrimeSum += inputNumb;
                }
                else if (inputNumb % 3 == 0 && inputNumb != 3)
                {
                    nonPrimeSum += inputNumb;
                }
                else if (inputNumb % 5 == 0 && inputNumb != 5)
                {
                    nonPrimeSum += inputNumb;
                }
                else if (inputNumb % 7 == 0 && inputNumb != 7)
                {
                    nonPrimeSum += inputNumb;
                }
                else
                {
                    primeSum += inputNumb;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");




        }
    }
}
