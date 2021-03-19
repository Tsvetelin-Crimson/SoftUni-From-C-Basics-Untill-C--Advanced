using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class coins
    {
        static void Main(string[] args)
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coinCounter = 0;
            change *= 100; 
            while (change > 0)
            {
                if(change >= 200)
                {                  
                    change -= 200;
                    coinCounter++;
                }
                else if (change >= 100)
                {                   
                    change -= 100;
                    coinCounter++;
                }
                else if(change >= 50)
                {                    
                    change -= 50;
                    coinCounter++;
                }
                else if(change >= 20)
                {                   
                    change -= 20;
                    coinCounter++;
                }
                else if (change >= 10)
                {                   
                    change -= 10;
                    coinCounter++;
                }
                else if (change >= 5)
                {
                    change -= 5;
                    coinCounter++;                    
                }
                else if (change >= 2)
                {
                    change -= 2;
                    coinCounter++;
                }
                else if (change >= 1)
                {
                   change -= 1;
                    coinCounter++;                  
                }
                else
                {
                    break;
                }
            }
            
            Console.WriteLine(coinCounter);

        }
    }
}
