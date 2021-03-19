using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExam
{
    class Fourth
    {
        static void Main(string[] args)
        {
            double singerPrice = double.Parse(Console.ReadLine()),
                endProfit = 0;
            string numberOfPeopleInGroup = "";
            int numberOfPeople = 0;
                 
            while ((numberOfPeopleInGroup = Console.ReadLine()) != "The restaurant is full")
            {
                int numberOfPeoplePerGroup = int.Parse(numberOfPeopleInGroup);
                numberOfPeople += numberOfPeoplePerGroup; 
                if (numberOfPeoplePerGroup >= 5)
                {
                    endProfit += numberOfPeoplePerGroup * 70; 
                }
                else
                {
                    endProfit += numberOfPeoplePerGroup * 100;
                }
            }

            if (endProfit < singerPrice)
            {
                Console.WriteLine($"You have {numberOfPeople} guests and {endProfit} leva income, but no singer.");
            }
            else
            {
                endProfit -= singerPrice;
                Console.WriteLine($"You have {numberOfPeople} guests and {endProfit} leva left.");
            }


        }
    }
}
