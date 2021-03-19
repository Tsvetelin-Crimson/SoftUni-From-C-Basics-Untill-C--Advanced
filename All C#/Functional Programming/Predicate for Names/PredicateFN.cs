using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_for_Names
{
    class PredicateFN
    {
        static void Main(string[] args)
        {
            
            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();
            //Func<int, bool> predicate = n => n % numb != 0;

            names = names.Where(n => n.Length <= length).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
