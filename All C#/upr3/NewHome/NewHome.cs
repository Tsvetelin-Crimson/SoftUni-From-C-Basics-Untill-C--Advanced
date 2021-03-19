using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHome
{
    class NewHome
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double money = 0;
            switch (typeOfFlower)
            {
                case "Roses":
                    money = numberOfFlowers * 5.0;
                    break;
                case "Dahlias":
                    money = numberOfFlowers * 3.80;
                    break;
                case "Tulips":
                    money = numberOfFlowers * 2.80;
                    break;
                case "Narcissus":
                    money = numberOfFlowers * 3.0;
                    break;
                case "Gladiolus":
                    money = numberOfFlowers * 2.50;
                    break;
            }

            if (numberOfFlowers > 80 && typeOfFlower == "Roses")
            {
                money *= 0.90;
            }
            else if (numberOfFlowers > 90 && typeOfFlower == "Dahlias")
            {
                money *= 0.85;
            }
            else if (numberOfFlowers > 80 && typeOfFlower == "Tulips")
            {
                money *= .85;
            }
            else if (numberOfFlowers < 120 && typeOfFlower == "Narcissus")
            {
                money *= 1.15;
            }
            else if (numberOfFlowers < 80 && typeOfFlower == "Gladiolus")
            {
                money *= 1.20;
            }

            if (budget >= money)
            {
                budget = budget - money;
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlower} and {budget:F2} leva left.");
            }
            else
            {
                budget = Math.Abs(budget - money);
                Console.WriteLine($"Not enough money, you need {budget:F2} leva more.");
            }


        }
    }
}
