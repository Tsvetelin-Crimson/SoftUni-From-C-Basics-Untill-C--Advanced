using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Water_Overflow
{
    class WaterO
    {
        static void Main(string[] args)
        {
            int maxCapacity = 255,
               inputTimes = int.Parse(Console.ReadLine()),
               capacity = 0;

            for (int i = 0; i < inputTimes; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (capacity + liters <= maxCapacity)
                {
                    capacity += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(capacity);
        }
    }
}
