using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Factory
{
    class COOKIE
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            string ingredients = Console.ReadLine();
            int combinedIngredients = 0; //could use bool equations (flour = false , sugar = false ...) + switch
            for (int i = 1; i <= batches;)
            {
                
                while (ingredients != "Bake!")
                {
                    if (ingredients == "flour" || ingredients == "eggs" || ingredients == "sugar")
                    {
                        combinedIngredients++;
                    }
                    
                    ingredients = Console.ReadLine();
                }

                if (combinedIngredients >= 3)
                {
                    Console.WriteLine($"Baking batch number {i}...");
                    i++;
                    combinedIngredients = 0;
                }
                else
                {
                    Console.WriteLine("The batter should contain flour, eggs and sugar!");
                }
                ingredients = "";
            }


        }
    }
}
