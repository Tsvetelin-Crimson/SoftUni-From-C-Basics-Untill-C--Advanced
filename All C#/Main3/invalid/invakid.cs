using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalid
{
    class invakid
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 200)
            {
                Console.WriteLine("invalid");
            }
            else if (number < 100)
            {
                if (number != 0)
                {
                    Console.WriteLine("invalid");
                }
                
            }
        }
    }
}
