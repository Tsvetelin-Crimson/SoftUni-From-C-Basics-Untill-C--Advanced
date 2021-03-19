using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_odd_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int even = 0, odd = 0;

            for (int i = 0; i < n; i++)
            {
                int numb = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    even += numb;
                }
                else
                {
                    odd += numb;
                }
            }

            if (odd == even)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {odd}");
            }
            else
            {
                int diff = Math.Abs(odd - even);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {diff}");
            }

        }
    }
}
