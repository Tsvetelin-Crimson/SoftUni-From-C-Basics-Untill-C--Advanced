using Microsoft.VisualBasic;
using System;
using System.Text;

namespace E07Tuple
{
    public class TupleMain
    {
        static void Main(string[] args)
        {
            
            string[] firstTokens = Console.ReadLine().Split();
            string fullName = firstTokens[0] + " " + firstTokens[1];
            string adress = firstTokens[2];
            string town = firstTokens[3];//string.Join(' ', firstTokens, 3, firstTokens.Length - 3);


            MyTreeuple<string, string, string> firstTreeuple = new MyTreeuple<string, string, string>(fullName, adress, town);
            Console.WriteLine(firstTreeuple); 

            string[] secondTokens = Console.ReadLine().Split();
            string name = secondTokens[0];
            int litersOfBeer = int.Parse(secondTokens[1]);
            bool drunkness = false; // dont have this as true initially it will break 2 tests for some reason
            if (secondTokens[2] == "drunk")
                drunkness = true;


            MyTreeuple<string, int, bool> secondTreeuple = new MyTreeuple<string, int, bool>(name, litersOfBeer, drunkness);
            Console.WriteLine(secondTreeuple); 



            string[] thirdTokens = Console.ReadLine().Split();
            string othername = thirdTokens[0];
            double accountBalance = double.Parse(thirdTokens[1]);
            string bankName = thirdTokens[2];
            MyTreeuple<string, double, string> thirdTreeuple = new MyTreeuple<string, double, string>(othername, accountBalance, bankName);
            Console.WriteLine(thirdTreeuple);
            

        }
    }
}
