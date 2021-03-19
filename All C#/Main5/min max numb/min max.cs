using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_max_numb
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumb = int.Parse(Console.ReadLine());

            int max = int.MinValue, min = int.MaxValue;

            for (int i = 0; i < inputNumb; i++)
            {
                int input = int.Parse(Console.ReadLine());


                if (max < input)
                {
                    max = input;
                }

                if (min > input)
                {
                    min = input;
                }

            }

            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");

        }
    }
}
