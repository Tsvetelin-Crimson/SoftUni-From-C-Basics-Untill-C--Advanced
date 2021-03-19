using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLatinLeters
{
    class TriplesOfLL
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());


            for (int firstNumb = 0; firstNumb < length; firstNumb++)
            {
                for (int secondtNumb = 0; secondtNumb < length; secondtNumb++)
                {
                    for (int thirdNumb = 0; thirdNumb < length; thirdNumb++)
                    {                                            
                        Console.WriteLine($"{ (char)(firstNumb + 'a')}{ (char)(secondtNumb + 'a')}{ (char)(thirdNumb + 'a')}");
                    }
                }
            }







        }
    }
}
