using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coding
{
    class coding
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int numb = int.Parse(number);

            for (int i = 0; i < number.Length; i++)
            {
                int lastDigit = numb % 10;
                for (int j = 0; j < lastDigit; j++)
                {
                    Console.Write((char)(lastDigit + 33));

                }
                if (lastDigit == 0)
                {
                    Console.Write("ZERO");
                }
                numb = numb / 10;
                Console.WriteLine();
            }




        }
    }
}
