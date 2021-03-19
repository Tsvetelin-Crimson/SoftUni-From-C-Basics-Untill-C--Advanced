using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_15
{
    class timeplus15
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine()), minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 15;
            
            if (minutes >= 60)
            {
                hours = hours + 1;
                minutes = minutes - 60;
            }
            if (hours == 24)
            {
                hours = 0;
            }

            if (minutes <= 9)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
