using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Sum
{
    class Equals
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool exists = false;
            int theNumber = 0;


            for (int i = 0; i < arr.Length; i++) // fix if arr.length = 1
            {
                int rightSum = 0,
                    leftSum = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {                   
                        rightSum += arr[j];                               
                }
                for (int j = i; j > 0; j--)
                {
                    leftSum += arr[j - 1];
                }
                if (rightSum == leftSum) 
                {
                    exists = true;                
                    theNumber = i;
                    break;
                }
            }
             if (exists)
            {
                Console.WriteLine(theNumber);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
