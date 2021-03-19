using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum2Numbs
{
    class Sum2
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()),
                end = int.Parse(Console.ReadLine()),
                magicNumb = int.Parse(Console.ReadLine()),
                counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == magicNumb)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumb})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumb}");


        }
    }
}
