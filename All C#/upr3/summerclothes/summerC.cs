using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summerclothes
{
    class summerC
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            string outfit = "";
            string shoes = "";
            switch (timeOfDay)
            {
                case "Morning":
                    if(temperature <=18 && temperature>=10)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if(temperature >18 && temperature <=24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature >24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (temperature <= 18 && temperature >= 10)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (temperature > 24)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    if (temperature <= 18 && temperature >= 10)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;
            }

            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and { shoes}.");

        }
    }
}
