using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()),
                end = int.Parse(Console.ReadLine()),
                sum = 0; 

            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");

                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");




        }
    }
}
