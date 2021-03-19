using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Equal_Elements
{
    class MaxSOEE
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            int longestStreak = 0,
                leftmostInteger = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                int currStreak = 0;
                for (int setBeingChecked = i + 1; setBeingChecked < arr.Length; setBeingChecked++)
                {
                    
                    if (arr[i] == arr[setBeingChecked])
                    {
                        currStreak++;                        
                    }
                    else
                    {
                        break;
                    }
                }
                currStreak++;
                if (currStreak > longestStreak)
                {
                    
                    longestStreak = currStreak;
                    leftmostInteger = i;
                }
            }          
            for (int i = 0; i < longestStreak; i++)
            {
                   Console.Write(arr[leftmostInteger] + " ");
            }                    
        }
    }
}
