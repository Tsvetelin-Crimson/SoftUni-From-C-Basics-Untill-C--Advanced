using System;

namespace CsharpOOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Box box = new Box(width, length, height);

                Console.WriteLine($"Surface Area - {box.GetSurface():F2}");
                Console.WriteLine($"Lateral Surface Area - {box.GetLateralSurface():F2}");
                Console.WriteLine($"Volume - {box.GetVolume():F2}");
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            

        }
    }
}
