using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr_5
{
    class convertorME
    {
        static void Main(string[] args)
        {
            double integer = double.Parse(Console.ReadLine());
            string unitIn = Console.ReadLine();
            string unitOut = Console.ReadLine();

            double integerOut = 0;
            if(unitIn == "m")
            {
                switch (unitOut)
                {
                    case "cm":
                        integer = integer * 100;
                        break;
                    case "mm":
                        integer = integer * 1000;
                        break;
                }
            }
            else if (unitIn == "cm")
            {
                switch (unitOut)
                {
                    case "m":
                        integer =  integer * 0.01;
                        break;
                    case "mm":
                        integer = integer * 10;
                        break;
                }
            }
            else if (unitIn == "mm")
            {
                switch (unitOut)
                {
                    case "m":
                        integer = integer * 0.001;
                        break;
                    case "cm":
                        integer = integer * 0.1;
                        break;
                }
            }

            Console.WriteLine($"{integer:F3}");

        }
    }
}
