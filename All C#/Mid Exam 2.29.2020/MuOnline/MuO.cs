using System;

namespace MuOnline
{
    class MuO
    {
        static void Main(string[] args)
        {
            int initialHealth = 100;
            int bitcoin = 0;

            string[] rooms = Console.ReadLine().Split("|");


            for (int i = 0; i < rooms.Length; i++)
            {
                string[] tokensRooms = rooms[i].Split(" ");
                string command = tokensRooms[0];
                int number = int.Parse(tokensRooms[1]);

                if (initialHealth <= 0)
                {
                    Console.WriteLine($"You died! Killed by {command}.");
                    Console.WriteLine($"Best room: {++i}");
                    return;
                }
                else if (command == "potion")
                {
                    if (number + initialHealth > 100)
                    {
                        number = 100 - initialHealth;
                        initialHealth = 100;                        
                    }
                    else
                    {
                        initialHealth += number;
                    }
                    Console.WriteLine($"You healed for {number} hp.");
                    Console.WriteLine($"Current health: {initialHealth} hp.");
                    
                }
                else if (command == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");
                    bitcoin += number;
                }
                else
                {
                    initialHealth -= number;
                    if (initialHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {++i}");
                        return;
                    }
                    Console.WriteLine($"You slayed {command}.");
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {initialHealth}");

        }
    }
}
