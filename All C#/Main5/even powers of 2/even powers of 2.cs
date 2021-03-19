using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= n; i+=2)
            {
                double numb = Math.Pow(2,i);
                Console.WriteLine(numb);

            }

        }
    }
}
