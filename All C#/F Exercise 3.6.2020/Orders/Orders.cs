using System;
using System.Collections.Generic;

namespace Orders
{
    class Orders
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productPrices = new Dictionary<string, decimal>();
            Dictionary<string, int> productQtty = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine())!= "buy")
            {
                string[] inputTokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                decimal price = decimal.Parse(inputTokens[1]);
                int    qtty = int.Parse(inputTokens[2]);
                if (!productPrices.ContainsKey(name))
                {
                    productPrices[name] = 0m;
                    productQtty[name] = 0;
                }

                productQtty[name] += qtty;
                productPrices[name] = price;
            }

            foreach (var item in productPrices)
            {
                string name = item.Key;
                decimal price = item.Value;
                int qtty = productQtty[name];
                
                Console.WriteLine($"{name} -> {price * qtty:F2}");

            }



        }
    }
}
