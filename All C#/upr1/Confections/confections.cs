using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confections
{
    class confections
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int wafers = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakeValue = 45, waferValue = 5.80, pancakeValue = 3.20;
            double cakeBGN = cakes * cakeValue;
            double waferBGN = wafers * waferValue;
            double pancakeBGN = pancakes * pancakeValue;
            double BGNDay = (cakeBGN + waferBGN + pancakeBGN) * confectioners;

            double BGNAll = BGNDay * days;
            double expenses = BGNAll / 8;
            double BGN = BGNAll - expenses;

            Console.WriteLine($"{BGN:F2}");


        }
    }
}
