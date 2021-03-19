using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestNum
{
    class low
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine()),
                input = int.Parse(Console.ReadLine());
            int inputShadow = input;
            while (numberOfNumbers > 1)
            {
                if (input < inputShadow)
                {
                    inputShadow = input;
                    input = int.Parse(Console.ReadLine());
                }
                else
                {
                    input = int.Parse(Console.ReadLine());
                }
                --numberOfNumbers;
            }
            if (input < inputShadow)
            {
                inputShadow = input;
            }

            Console.WriteLine(inputShadow);
        }
    }
}
