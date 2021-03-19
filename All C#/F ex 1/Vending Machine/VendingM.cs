using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class VendingM
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumMoney = 0;

            while (input != "Start")
            {
                double money = double.Parse(input);
                if (money == 1 || money == 2 || money == 0.1 || money == 0.2 || money == 0.5)
                {
                    sumMoney += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            double nutsPrice = 2.0,
                waterPrice = 0.7,
                crispsPrice = 1.5,
                sodaPrice = 0.8,
                cokePrice = 1.0;
            while (input != "End")
            {
                if (input == "Nuts")
                {
                    if (sumMoney >= nutsPrice)
                    {
                        sumMoney -= nutsPrice;
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else if (input == "Water")
                {
                    if (sumMoney >= waterPrice)
                    {
                        sumMoney -= waterPrice;
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }


                }
                else if (input == "Crisps")
                {
                    if (sumMoney >= crispsPrice)
                    {
                        sumMoney -= crispsPrice;
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }


                }
                else if (input == "Soda")
                {
                    if (sumMoney >= sodaPrice)
                    {
                        sumMoney -= sodaPrice;
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (input == "Coke")
                {
                    if (sumMoney >= cokePrice)
                    {
                        sumMoney -= cokePrice;
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumMoney:F2}");



        }
    }
}
