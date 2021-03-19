using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            while (numb <= 0 || numb > 100)
            {
                Console.WriteLine("Invalid number!");
                numb = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is:" + numb);
        }
    }
}
