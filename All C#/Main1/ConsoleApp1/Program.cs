using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = int.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * radius;
            double face = Math.PI * radius * radius:
            Console.WriteLine($"{perimeter:F2}");
            Console.WriteLine($"{face:F2}");
        }
    }
}
