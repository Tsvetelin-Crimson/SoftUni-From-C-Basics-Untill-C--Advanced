using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr7
{
    class GODZILLA
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double costForClothesForOneStatist = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothesCost = costForClothesForOneStatist * statists;

            if(statists > 150)
            {
                clothesCost = clothesCost - (clothesCost * 0.10);
            }

            double budgetLeft = budget - clothesCost - decor;

            if (budgetLeft < 0)
            {

                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budgetLeft):F2} leva more.");        
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budgetLeft:F2} leva left.");

            }

        }
    }
}
