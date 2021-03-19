using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_Exercise_2._14._2020
{
    class Train
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string commands;
            while ((commands = Console.ReadLine()) != "end")
            {
                string[] commArray = commands.Split().ToArray();

                if (commArray.Length == 2)
                {                   
                    wagons.Add(int.Parse(commArray[1]));
                }
                else if (commArray.Length == 1)
                {
                    FillWagonIfPossible(wagons, maxCapacity, commArray);
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void FillWagonIfPossible(List<int> wagons, int maxCapacity, string[] commArray)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (wagons[i] + int.Parse(commArray[0]) <= maxCapacity)
                {
                    wagons[i] = wagons[i] + int.Parse(commArray[0]);
                    break;
                }
            }
        }
    }
}
