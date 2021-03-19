using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocketMoneyPerDay = double.Parse(Console.ReadLine()),
                moneyPerDay = double.Parse(Console.ReadLine()),
                expenses = double.Parse(Console.ReadLine()),
                priceForGift = double.Parse(Console.ReadLine());

            double moneyGained = (5 * moneyPerDay) + (5 * pocketMoneyPerDay),
                
                endMoney = moneyGained - expenses;


            if (endMoney >= priceForGift)
            {
                Console.WriteLine($"Profit: {endMoney:F2} BGN, the gift has been purchased.");
            }
            else
            {
                priceForGift -= endMoney;
                Console.WriteLine($"Insufficient money: {priceForGift:F2} BGN. ");
            }
        }
    }
}
