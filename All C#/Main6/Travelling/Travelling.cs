using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            while (country != "End")
            {
                double budgetNeeded = double.Parse(Console.ReadLine());
                for (double i = 0; i < budgetNeeded;)
                {
                    double saved = double.Parse(Console.ReadLine());

                    i += saved;
                }
                Console.WriteLine($"Going to {country}!");
                country = Console.ReadLine();
            }



        }
    }
}
