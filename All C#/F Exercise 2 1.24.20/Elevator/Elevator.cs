using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine()),
                maxCapacity = int.Parse(Console.ReadLine()),
                courses = 0;

            courses = people / maxCapacity;

            if (people % maxCapacity != 0)
            {
                courses++;
            }

            Console.WriteLine(courses);



        }
    }
}
