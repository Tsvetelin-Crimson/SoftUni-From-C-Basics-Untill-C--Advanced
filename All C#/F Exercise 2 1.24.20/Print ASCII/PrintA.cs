using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_ASCII
{
    class PrintA
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine()),
                end = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = start; i <= end; i++)
            {                
                result += (char)i + " "; //dont forget to check what you're running

            }

            Console.WriteLine(result);



        }
    }
}
