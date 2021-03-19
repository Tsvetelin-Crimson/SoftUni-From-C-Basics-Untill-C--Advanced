using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace left_right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0, right = 0;
            for (int i = 0; i < n; i++)
            {
                left = left + int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                right = right + int.Parse(Console.ReadLine());
            }

            if (right == left)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                int diff = Math.Abs(left - right);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
