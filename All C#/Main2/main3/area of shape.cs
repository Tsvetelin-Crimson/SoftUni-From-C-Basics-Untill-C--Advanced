using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main3
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();

            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = side * side;
                Console.WriteLine($"{area:F3}");
            }
            else if (shape == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double lenght = double.Parse(Console.ReadLine());
                double area = lenght * width;
                Console.WriteLine($"{area:F3}");
            }
            else if (shape == "triangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = lenght * height / 2;
                Console.WriteLine($"{area:F3}");
            }
            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine($"{area:F3}");
            }
        }
    }
}
