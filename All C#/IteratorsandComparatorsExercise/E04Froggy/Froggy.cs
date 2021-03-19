using System;
using System.Linq;

namespace E04Froggy
{
    class Froggy
    {
        static void Main(string[] args)
        {
            int[] stones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Lake lake = new Lake(stones);


            Console.WriteLine(string.Join(", ", lake));
            //foreach (int stone in lake)
            //{
            //    Console.Write($"{stone}, ");
            //}
           



        }
    }
}
