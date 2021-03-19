using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop2
{
    class shop2
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine(), day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            switch(day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            double price = quantity * 2.50;
                            Console.WriteLine($"{price:F2}");
                            break;
                        case "apple":
                            double price1 = quantity * 1.20;
                            Console.WriteLine($"{price1:F2}");
                            break;
                        case "orange":
                            double price2 = quantity * 0.85;
                            Console.WriteLine($"{price2:F2}");
                            break;
                        case "grapefruit":
                            double price3 = quantity * 1.45;
                            Console.WriteLine($"{price3:F2}");
                            break;
                        case "kiwi":
                            double price4 = quantity * 2.70;
                            Console.WriteLine($"{price4:F2}");
                            break;
                        case "pineapple":
                            double price5 = quantity * 5.50;
                            Console.WriteLine($"{price5:F2}");
                            break;
                        case "grapes":
                            double price6 = quantity * 3.85;
                            Console.WriteLine($"{price6:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            double price = quantity * 2.70;
                            Console.WriteLine($"{price:F2}");
                            break;
                        case "apple":
                            double price1 = quantity * 1.25;
                            Console.WriteLine($"{price1:F2}");
                            break;
                        case "orange":
                            double price2 = quantity * 0.90;
                            Console.WriteLine($"{price2:F2}");
                            break;
                        case "grapefruit":
                            double price3 = quantity * 1.60;
                            Console.WriteLine($"{price3:F2}");
                            break;
                        case "kiwi":
                            double price4 = quantity * 3.00;
                            Console.WriteLine($"{price4:F2}");
                            break;
                        case "pineapple":
                            double price5 = quantity * 5.60;
                            Console.WriteLine($"{price5:F2}");
                            break;
                        case "grapes":
                            double price6 = quantity * 4.20;
                            Console.WriteLine($"{price6:F2}");
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                            break;
                default:
                    Console.WriteLine("error");
                    break;
            }

        }
    }
}
