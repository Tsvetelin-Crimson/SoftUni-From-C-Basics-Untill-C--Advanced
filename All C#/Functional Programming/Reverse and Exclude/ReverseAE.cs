using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_and_Exclude
{
    class ReverseAE
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int numb = int.Parse(Console.ReadLine());

            numbers.Reverse();
            Func<int, bool> predicate = n => n % numb != 0;
            numbers = numbers.Where(predicate).ToList();
            Console.WriteLine(string.Join(' ', numbers));
           // Func<List<int>, List<int>> 
        }
    }
}
