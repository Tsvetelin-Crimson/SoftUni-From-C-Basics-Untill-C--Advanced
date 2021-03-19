using System;
using System.Linq;
using System.Threading.Channels;

namespace E03Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string number in numbers)
            {                
                if (!number.All(char.IsDigit))
                {
                    Console.WriteLine("Invalid number!");
                }
                else if (number.Length == 7)
                {
                    stationaryPhone.Call(number);
                }
                else if (number.Length == 10)
                {
                    smartphone.Call(number);
                }
            }


            string[] sites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string site in sites)
            {
                bool hasNumbers = false;
                for (int i = 0; i < site.Length; i++)
                {
                    if (char.IsDigit(site[i]))
                    {
                        hasNumbers = true;
                    }
                }
                if (hasNumbers)
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    smartphone.Browse(site);
                }
            }
        }
    }
}
