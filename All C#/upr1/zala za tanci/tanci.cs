using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zala_za_tanci
{
    class tanci
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double Wa = double.Parse(Console.ReadLine());

            double roomSpace = (W * 100) * (L * 100);
            double wardrobe = (Wa * 100) * (Wa * 100);
            double bench = roomSpace / 10;

            double roomFreeSpace = roomSpace - (wardrobe + bench);

            double NumOfDancers = Math.Floor(roomFreeSpace / (40 + 7000));

            Console.WriteLine($"{NumOfDancers} ");
        }
    }
}
