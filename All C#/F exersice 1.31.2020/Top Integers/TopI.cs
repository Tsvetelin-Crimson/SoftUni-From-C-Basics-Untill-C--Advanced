using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Top_Integers
{
    class TopI
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                bool isbigger = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (j == arr.Length)
                    {
                    }
                    else if (arr[i] > arr[j])
                    {
                    }
                    else
                    {
                        isbigger = false;
                        break;
                    }
                }
                if (isbigger)
                {
                    Console.Write(arr[i] + " ");
                }
            }          
        }
    }
}
