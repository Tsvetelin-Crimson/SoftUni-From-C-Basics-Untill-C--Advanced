using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifth
{
    class Fifth
    {
        static void Main(string[] args)
        {
            int numberOfPassangers = int.Parse(Console.ReadLine()),
                numberOfStops = int.Parse(Console.ReadLine());
            int stop = 1;
            for (; stop <= numberOfStops; stop++)
            {
                int leavers = int.Parse(Console.ReadLine()),
                    riders = int.Parse(Console.ReadLine());


                numberOfPassangers -= leavers;
                numberOfPassangers += riders;
            }
            if (stop % 2 == 0)
            {
                numberOfPassangers += 2;
            }



            Console.WriteLine($"The final number of passengers is : {numberOfPassangers}");

        }
    }
}
