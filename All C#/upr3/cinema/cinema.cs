using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class cinema
    {
        static void Main(string[] args)
        {
            string typeOfProj = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine()), columns = int.Parse(Console.ReadLine());

            double money = 0;
            int allChairs = rows * columns;
            switch (typeOfProj)
            {
                case "Premiere":
                    money = allChairs * 12.00;
                    break;
                case "Normal":
                    money = allChairs * 7.50;
                    break;
                case "Discount":
                    money = allChairs * 5.00;
                    break;
            }
               Console.WriteLine($"{money:F2} leva");
            }
            
            
    }
}
