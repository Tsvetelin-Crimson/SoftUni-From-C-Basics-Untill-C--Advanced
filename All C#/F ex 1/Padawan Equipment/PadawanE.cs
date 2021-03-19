using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan_Equipment
{
    class PadawanE
    {
        static void Main(string[] args)
        {
            double startingMoney = double.Parse(Console.ReadLine());
            int numbOfStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine()),
                robesPrice = double.Parse(Console.ReadLine()),
                beltsPrice = double.Parse(Console.ReadLine()),
                sum = 0;


            double lightsabers = lightsabersPrice * Math.Ceiling(numbOfStudents * 1.10),
                robes = robesPrice * numbOfStudents,
                belts = beltsPrice * numbOfStudents;            

            if (numbOfStudents >= 6)
            {
                belts = belts - ((numbOfStudents / 6) * beltsPrice);
            }
            sum = lightsabers + robes + belts;

            if (startingMoney >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
            }
            else
            {
                sum -= startingMoney;
                Console.WriteLine($"Ivan Cho will need {sum:F2}lv more.");

            }
        }
    }
}
