using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class VAC
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine()),
                moneyStart = double.Parse(Console.ReadLine());
            int days = 0;
            int spendingLimit = 0;
            while (moneyStart < moneyNeeded)
            {
                string typeOfAction = Console.ReadLine();
                double amountOfMoney = double.Parse(Console.ReadLine());
                
                days++;

                if (typeOfAction == "spend")
                {
                    moneyStart -= amountOfMoney;
                    if (moneyStart < 0)
                    {
                        moneyStart = 0;
                    }
                    spendingLimit++;
                }
                else
                {
                    moneyStart += amountOfMoney;

                    spendingLimit = 0;
                }
                if (spendingLimit == 5)
                {
                    break;
                }

            }

            if (spendingLimit == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(days);
            }
            else
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
