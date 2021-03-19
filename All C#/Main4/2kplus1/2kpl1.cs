using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2kplus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine()),
                numb1 = 1;


            while (numb1 <= numb)
            {
                Console.WriteLine(numb1);
                numb1 = numb1 * 2 + 1;
            }
        }
    }
}
