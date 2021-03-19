using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multTable
{
    class MultTable
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 11; i++)
            {
                for (int z = 1; z < 11; z++)
                {
                    Console.WriteLine($"{i} * {z} = {i * z}");
                }
            }
        }
    }
}
