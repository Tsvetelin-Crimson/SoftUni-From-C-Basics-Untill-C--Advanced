using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class t4
    {
        static void Main(string[] args)
        {

            int coffeeGrams = int.Parse(Console.ReadLine());
            double profit = 0;

            while (coffeeGrams > 0)
            {
                string coffee = Console.ReadLine();

                if (coffee == "espresso")
                {
                    if (coffeeGrams >= 50)
                    {
                        profit += 3.00;
                        coffeeGrams -= 50;
                    }
                    else
                    {
                        Console.WriteLine("Not enough coffee!");
                    }
                }
                else if (coffee == "cappuccino")
                {
                    if (coffeeGrams >= 30)
                    {
                        profit += 3.5;
                        coffeeGrams -= 30;
                    }
                    else
                    {
                        Console.WriteLine("Not enough coffee!");
                    }
                }
                else if (coffee == "latte")
                {
                    if (coffeeGrams >= 20)
                    {
                        profit += 3.5;
                        coffeeGrams -= 20;
                    }
                    else
                    {
                        Console.WriteLine("Not enough coffee!");
                    }
                }
                else if (coffee == "closed")
                {
                    break;
                }
            }

            if (coffeeGrams == 0)
            {
                Console.WriteLine("No more coffee left!");
                Console.WriteLine($"Profit: {profit:F2} lv.");
            }
            else
            {
                Console.WriteLine($"Coffee left: {coffeeGrams}g");
                Console.WriteLine($"Profit: {profit:F2} lv.");
            }


        }
    }
}
