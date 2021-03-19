using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace combinations
{
    class comb
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine()),
                counter = 0;

            for (int x1 = 0; x1 < numb + 1; x1++)
            {
                for (int x2 = 0; x2 < numb + 1; x2++)
                {
                    for (int x3 = 0; x3 < numb + 1; x3++)
                    {
                        for (int x4 = 0; x4 < numb +1; x4++)
                        {
                            for (int x5 = 0; x5 < numb+1; x5++)
                            {
                                if (x1 + x2 + x3 + x4 + x5 == numb)
                                {
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);



        }
    }
}
