using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine(), city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            if (product == "coffee")
            {
                if (city == "Sofia")
                {
                    double coffeePrice = 0.50 * quantity;
                    Console.WriteLine(coffeePrice);
                }
                else if (city == "Plovdiv")
                {
                    double coffeePrice = 0.40 * quantity;
                    Console.WriteLine(coffeePrice);
                }
                else if (city == "Varna")
                {
                    double coffeePrice = 0.45 * quantity;
                    Console.WriteLine(coffeePrice);
                }
            }
            else if (product == "water")
            {
                if (city == "Sofia")
                {
                    double productPrice = 0.80 * quantity;
                    Console.WriteLine(productPrice);
                }
                else if (city == "Plovdiv")
                {
                    double productPrice = 0.70 * quantity;
                    Console.WriteLine(productPrice);
                }
                else if (city == "Varna")
                {
                    double productPrice = 0.70 * quantity;
                    Console.WriteLine(productPrice);
                }
            }
            else if (product == "beer")
            {
                if (city == "Sofia")
                {
                    double productPrice = 1.20 * quantity;
                    Console.WriteLine(productPrice);
                }
                else if (city == "Plovdiv")
                {
                    double productPrice = 1.15 * quantity;
                    Console.WriteLine(productPrice);
                }
                else if (city == "Varna")
                {
                    double productPrice = 1.10 * quantity;
                    Console.WriteLine(productPrice);
                }
            }
            else if (product == "sweets")
            {
                if (city == "Sofia")
                {
                    double productPrice = 1.45 * quantity;
                    Console.WriteLine(productPrice);
                }
                else if (city == "Plovdiv")
                {
                    double productPrice = 1.30 * quantity;
                    Console.WriteLine(productPrice);
                }
                else if (city == "Varna")
                {
                    double productPrice = 1.35 * quantity;
                    Console.WriteLine(productPrice);
                }
            }
            else if (product == "peanuts")
            {
                if (city == "Sofia")
                {
                    double productPrice = 1.60 * quantity;
                    Console.WriteLine(productPrice);
                }
                else if (city == "Plovdiv")
                {
                    double productPrice = 1.50 * quantity;
                    Console.WriteLine(productPrice);
                }
                else if (city == "Varna")
                {
                    double productPrice = 1.55 * quantity;
                    Console.WriteLine(productPrice);
                }
            }
        }
    }
}
