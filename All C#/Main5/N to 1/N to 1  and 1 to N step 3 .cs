using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_to_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //answer to first
            //int n = int.Parse(Console.ReadLine());

            // for (int i = n; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
