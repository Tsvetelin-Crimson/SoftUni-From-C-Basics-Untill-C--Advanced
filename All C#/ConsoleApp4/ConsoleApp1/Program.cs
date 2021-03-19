using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnedgy = int.Parse(Console.ReadLine());
            int wonBattles = 0;

            string input;
            while ((input = Console.ReadLine()) != "End of battle" && initialEnedgy > 0)
            {
                int energyRequired = int.Parse(input);

                if (energyRequired <= initialEnedgy)
                {
                    initialEnedgy -= energyRequired;
                    wonBattles++;
                }
                

                if (wonBattles % 3 == 0)
                {
                    initialEnedgy += wonBattles;
                }

                //if (initialEnedgy <= 0)
                //{
                //    break;
                //}
            }

            if (initialEnedgy <= 0)
            {
                Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initialEnedgy} energy");
            }
            else
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnedgy}");
            }
        }
    }
}
