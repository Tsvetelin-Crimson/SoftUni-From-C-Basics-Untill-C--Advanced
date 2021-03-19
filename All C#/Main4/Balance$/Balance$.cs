using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbLoans = int.Parse(Console.ReadLine()),
                numbVar = 0;
            double total = 0;
            
            while (numbLoans > numbVar)
            {
               double  input = double.Parse(Console.ReadLine());
               numbVar++;
                if (input > 0)
                {
                    total = total + input;
                    Console.WriteLine($"Increase: {input:F2}");
                    
                   
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }

            Console.WriteLine($"Total: {total:F2}");
        }
    }
}
