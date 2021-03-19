using System;
using System.Collections.Generic;

namespace E05GenericCountMethodStringsAndInts
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            List<double> throwaway = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double item = double.Parse(Console.ReadLine());
                throwaway.Add(item);
            }
            box.AddList(throwaway);
            double itemToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.GetCountOfBiggerItems(itemToCompare));

        }
    }
}
