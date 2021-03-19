using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine()),
                cakeLength = int.Parse(Console.ReadLine()),
                cake = cakeWidth * cakeLength;

            while (cake >= 0)
            {
                string cakeTaken = Console.ReadLine();

                if (cakeTaken == "STOP")
                {
                    break;
                }
                cake -= int.Parse(cakeTaken);

            }

            if (cake >= 0)
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
            else
            {
                cake = Math.Abs(cake);
                Console.WriteLine($"No more cake left! You need {cake} pieces more.");
            }

        }
    }
}
