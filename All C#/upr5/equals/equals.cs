using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equals
{
    class equals
    {
        static void Main(string[] args)
        {

            // worse in base than equals2 and doesn't work yet
            int numbOfNumbs = int.Parse(Console.ReadLine()),
                sum = 0,
                diff = 0,
                diffMax = 0,
                sum2 = 0,
                endSum = 0,
                counter = 0;




            for (int i = 1; i <= numbOfNumbs * 2 || counter == 5; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                counter++;
                if (counter == 5)
                {
                    counter = 1;
                    if (endSum == 0)
                    {
                        endSum = sum2;
                    }
                    else
                    {
                        endSum = sum;
                    }
                    diff = Math.Abs(sum2 - endSum);
                    if (diff > diffMax)
                    {
                        diffMax = diff;
                    }
                    if (endSum != 0)
                    {
                        endSum = 0;
                    }

                    sum = 0;
                    sum2 = 0;

                }
                if (counter == 1 || counter == 2)
                {
                    sum += numb;
                }
                else if (counter == 3 || counter == 4)
                {
                    sum2 += numb;
                }
            }
            diff = Math.Abs(sum2 - sum);
            if (diff > diffMax)
            {
                diffMax = diff;
            }
            endSum = sum;
            if (diffMax != 0)
            {
                Console.WriteLine($"No, maxdiff={diffMax}");
            }
            else
            {
                Console.WriteLine($"Yes, value={endSum}");
            }

        }
    }
}
