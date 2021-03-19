using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class t5
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double elecTax = 0,
                waterTax = 0,
                internetTax = 0,
                otherTax = 0;

            for (int i = 0; i < months; i++)
            {
                double electrTaxInput = double.Parse(Console.ReadLine());

                elecTax += electrTaxInput;
                waterTax += 20;
                internetTax += 15;

                otherTax += (electrTaxInput + 20 + 15) + ((electrTaxInput + 20 + 15) * 0.20);
            }

            double averagePerMonth = (elecTax + waterTax + internetTax + otherTax) / months; 

            Console.WriteLine($"Electricity: {elecTax:F2} lv");
            Console.WriteLine($"Water: {waterTax:F2} lv");
            Console.WriteLine($"Internet: {internetTax:F2} lv");
            Console.WriteLine($"Other: {otherTax:F2} lv");
            Console.WriteLine($"Average: {averagePerMonth:F2} lv");
        }
    }
}
