using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class TriFunction
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> people = Console.ReadLine().Split().ToList();

            Func<string, int> getAscii = p => p.Select(c => (int)c).Sum();

            Func<List<string>, int, Func<string, int>, string> getName = (people, n, func)
                => people.FirstOrDefault(p => func(p) >= n);

            Console.WriteLine(getName(people, n, getAscii));
        }
    }
}
