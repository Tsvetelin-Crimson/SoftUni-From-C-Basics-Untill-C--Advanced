using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class Beerk
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            double biggestKeg = 0;
            string biggestKegName = "";

            for (int i = 0; i < numberOfInputs; i++)
            {
                string nameOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentKeg = Math.PI * radius * radius * height;

                if (currentKeg > biggestKeg)
                {
                    biggestKeg = currentKeg;
                    biggestKegName = nameOfKeg;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
