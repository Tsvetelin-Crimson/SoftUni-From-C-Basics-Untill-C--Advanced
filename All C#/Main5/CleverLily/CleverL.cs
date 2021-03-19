using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLily
{
    class CleverL
    {
        static void Main(string[] args)
        {
            double age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine()),
                priceForToy = double.Parse(Console.ReadLine()),
                currentMoney = 0,
                moneyForEvenBday = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneyForEvenBday += 10;
                    currentMoney += moneyForEvenBday;
                }
                else
                {
                    currentMoney += priceForToy; 
                }
            }
            currentMoney -= Math.Floor(age / 2);

            double diffOrChange = Math.Abs(currentMoney - washingMachinePrice);
            if (currentMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {diffOrChange:F2}");
            }
            else
            {
                Console.WriteLine($"No! {diffOrChange:F2}");
            }

        }
    }
}
