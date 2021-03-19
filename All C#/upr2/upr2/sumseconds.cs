using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr2
{
    class sumseconds
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secondTime + thirdTime;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds >= 10)
            {
                Console.WriteLine($"{minutes}:{seconds}");

            }
            else
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
        }
    }
}
