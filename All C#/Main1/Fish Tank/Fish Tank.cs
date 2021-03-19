using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = lenght * width * height;
            double volumeLeters = volume * 0.001;
            double percentA = percent * 0.01;
            double leters = volumeLeters * (1 - percentA);

            Console.WriteLine($"{leters:F3}");
        }
    }
}
