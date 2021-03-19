using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Expenses
{
    class RageE
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine()),
                mousePrice = double.Parse(Console.ReadLine()),
                keyboardPrice = double.Parse(Console.ReadLine()),
                displayPrice = double.Parse(Console.ReadLine()),
                expenses = 0,
                countHeadset = 0,
                countMouse = 0,
                countKeyboard = 0,
                countDisplay = 0;

            if (lostGameCount > 1)
            {
                countHeadset = lostGameCount / 2;
                countMouse = lostGameCount / 3;
                countKeyboard = lostGameCount / 6;
            }

            if (countKeyboard >= 2)
            {
                countDisplay = Math.Floor(countKeyboard / 2);
            }

            expenses = (countHeadset * headsetPrice) + (countMouse * mousePrice) + (countKeyboard * keyboardPrice) + (countDisplay * displayPrice);

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
