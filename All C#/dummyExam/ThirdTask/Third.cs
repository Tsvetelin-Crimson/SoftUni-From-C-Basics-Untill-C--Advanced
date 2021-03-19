using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Third
    {
        static void Main(string[] args)
        {
            string typeSushi = Console.ReadLine(),
                nameRestaurant = Console.ReadLine();
            int portion = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            double moneyForRestaurantAndOrder = 0;
            
            if (nameRestaurant == "Sushi Zone" || nameRestaurant == "Asian Pub" || nameRestaurant == "Sushi Time" || nameRestaurant == "Sushi Bar")
            {
                switch (nameRestaurant)
                {
                    case "Sushi Zone":
                        switch (typeSushi)
                        {
                            case "sashimi":
                                moneyForRestaurantAndOrder = 4.99;
                                break;
                            case "maki":
                                moneyForRestaurantAndOrder = 5.29;
                                break;
                            case "uramaki":
                                moneyForRestaurantAndOrder = 5.99;
                                break;
                            case "temaki":
                                moneyForRestaurantAndOrder = 4.29;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Sushi Time":
                        switch (typeSushi)
                        {
                            case "sashimi":
                                moneyForRestaurantAndOrder = 5.49;
                                break;
                            case "maki":
                                moneyForRestaurantAndOrder = 4.69;
                                break;
                            case "uramaki":
                                moneyForRestaurantAndOrder = 4.49;
                                break;
                            case "temaki":
                                moneyForRestaurantAndOrder = 5.19;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Sushi Bar":
                        switch (typeSushi)
                        {
                            case "sashimi":
                                moneyForRestaurantAndOrder = 5.25;
                                break;
                            case "maki":
                                moneyForRestaurantAndOrder = 5.55;
                                break;
                            case "uramaki":
                                moneyForRestaurantAndOrder = 6.25;
                                break;
                            case "temaki":
                                moneyForRestaurantAndOrder = 4.75;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Asian Pub":
                        switch (typeSushi)
                        {
                            case "sashimi":
                                moneyForRestaurantAndOrder = 4.50;
                                break;
                            case "maki":
                                moneyForRestaurantAndOrder = 4.80;
                                break;
                            case "uramaki":
                                moneyForRestaurantAndOrder = 5.50;
                                break;
                            case "temaki":
                                moneyForRestaurantAndOrder = 5.50;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                double endprice = portion * moneyForRestaurantAndOrder;

                if (order == "Y")
                {
                    endprice += (endprice * 0.2);
                }
                endprice = Math.Ceiling(endprice);

                Console.WriteLine($"Total price: {endprice} lv.");
            }
            else
            {
                Console.WriteLine($"{nameRestaurant} is invalid restaurant!");
            }

        }
    }
}
