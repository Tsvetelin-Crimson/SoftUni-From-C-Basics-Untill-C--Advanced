using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCommisions
{
    class tradec
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commision = 0;
            if ((city == "Sofia" || city == "Varna" || city == "Plovdiv") && sales >= 0)
            {
                if (city == "Sofia")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = sales * 0.05;
                    }
                    else if (sales <= 1000)
                    {
                        commision = sales * 0.07;
                    }
                    else if (sales <= 10000)
                    {
                        commision = sales * 0.08;
                    }
                    else
                    {
                        commision = sales * 0.12;
                    }
                    Console.WriteLine($"{commision:F2}");
                }
                else if (city == "Varna")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = sales * 0.045;
                    }
                    else if (sales <= 1000)
                    {
                        commision = sales * 0.075;
                    }
                    else if (sales <= 10000)
                    {
                        commision = sales * 0.10;
                    }
                    else
                    {
                        commision = sales * 0.13;
                    }
                    Console.WriteLine($"{commision:F2}");
                }
                else if (city == "Plovdiv")
                {
                    if (sales >= 0 && sales <= 500)
                    {
                        commision = sales * 0.055;
                    }
                    else if (sales <= 1000)
                    {
                        commision = sales * 0.08;
                    }
                    else if (sales <= 10000)
                    {
                        commision = sales * 0.12;
                    }
                    else
                    {
                        commision = sales * 0.145;
                    }
                    Console.WriteLine($"{commision:F2}");
                }
            }
            else 
            Console.WriteLine("error");
        }
    }
}
