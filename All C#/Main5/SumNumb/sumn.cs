using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumb
{
    class sumn
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                int input2 = int.Parse(Console.ReadLine());

                sum += input2;
            }
            Console.WriteLine(sum);

        }
    }
}
