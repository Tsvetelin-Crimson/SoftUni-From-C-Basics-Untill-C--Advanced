using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            decimal amountOfPeopleInGroup = decimal.Parse(Console.ReadLine());
            string typeOFGroup = Console.ReadLine(), 
                dayOfTheWeek = Console.ReadLine(); // only fri , sat and sun

            decimal priceFor1Person;
            decimal totalPrice = 1;

            if (typeOFGroup == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    priceFor1Person = 8.45M;
                    totalPrice = priceFor1Person * amountOfPeopleInGroup;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceFor1Person = 9.80M;
                    totalPrice = priceFor1Person * amountOfPeopleInGroup;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceFor1Person = 10.46M;
                    totalPrice = priceFor1Person * amountOfPeopleInGroup;
                }

                if (amountOfPeopleInGroup >= 30) //discount
                {
                    totalPrice *= 0.85M;
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            if (typeOFGroup == "Business")
            {
                decimal businessException = amountOfPeopleInGroup;
                if (amountOfPeopleInGroup >= 100)// "discount"
                {
                    businessException = amountOfPeopleInGroup - 10;
                }

                if (dayOfTheWeek == "Friday")
                {
                    priceFor1Person = 10.90M;
                    totalPrice = priceFor1Person * businessException;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceFor1Person = 15.60M;
                    totalPrice = priceFor1Person * businessException;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceFor1Person = 16;
                    totalPrice = priceFor1Person * businessException;
                }

                
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
            if (typeOFGroup == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    priceFor1Person = 15;
                    totalPrice = priceFor1Person * amountOfPeopleInGroup;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    priceFor1Person = 20;
                    totalPrice = priceFor1Person * amountOfPeopleInGroup;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    priceFor1Person = 22.50M;
                    totalPrice = priceFor1Person * amountOfPeopleInGroup;
                }

                if (amountOfPeopleInGroup >= 10 && amountOfPeopleInGroup <= 20) //discount
                {
                    totalPrice *= 0.95M;
                }
                Console.WriteLine($"Total price: {totalPrice:F2}");
            }
        }

        
    }
}
