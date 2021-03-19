using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    class pyr
    {
        static void Main(string[] args)
        {
            int mainNumb = int.Parse(Console.ReadLine()),
                mainCounter = 1;           
            

            for (int i = 1; i <= mainNumb; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (mainCounter > mainNumb)
                    {
                        
                        return;
                    }
                    Console.Write(mainCounter + " ");
                    mainCounter++;
                    
                }
                
                Console.WriteLine();
            }





        }
    }
}
