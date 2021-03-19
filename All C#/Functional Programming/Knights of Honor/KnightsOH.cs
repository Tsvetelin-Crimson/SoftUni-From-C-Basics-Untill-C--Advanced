using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Programming
{
    class ActionPoint
    {
        static void Main(string[] args)
        {
            Action<string> f = c => Console.WriteLine("Sir " + c);


            string[] arr = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            foreach (var item in arr)
            {
                f(item);
            }


        }
    }
}
