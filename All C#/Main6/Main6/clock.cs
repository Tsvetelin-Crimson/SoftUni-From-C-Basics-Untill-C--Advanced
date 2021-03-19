using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main6
{
    class clock
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 24; i++)
            {
                for (int z = 0; z < 60; z++)
                {
                    Console.WriteLine($"{i:D2}:{z:D2}");
                }               
            }
        }
    }
}
