using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    class Second
    {
        static void Main(string[] args)
        {
            double widthRocket = double.Parse(Console.ReadLine()),
                lenghtRocket = double.Parse(Console.ReadLine()),
                heightRocket = double.Parse(Console.ReadLine()),
                averageHeightAstonauts = double.Parse(Console.ReadLine());

            double rocketVolume = widthRocket * lenghtRocket * heightRocket;

            double roomVolume = (averageHeightAstonauts + 0.40) * 2 * 2;

            double astronautSpace = Math.Floor(rocketVolume / roomVolume);

            if (astronautSpace <3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (astronautSpace  > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else
            {
                Console.WriteLine($"The spacecraft holds {astronautSpace} astronauts. ");
            }


        }
    }
}
