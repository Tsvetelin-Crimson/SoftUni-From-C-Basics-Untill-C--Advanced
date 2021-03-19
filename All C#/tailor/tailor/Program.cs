using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tailor
{
    class Program
    {
        static void Main(string[] args)
        {
            int tablesNum = int.Parse(Console.ReadLine());
            double tableLength = double.Parse(Console.ReadLine());
            double tableWidth = double.Parse(Console.ReadLine());

           
            double tablecloth = tablesNum * (tableLength + 2 * 0.30) * (tableWidth + 2 * 0.30);
            double kareta = tablesNum * (tableLength / 2) * (tableLength / 2);

            double tableclValueUSD = 7;
            double USDTableCl = tablecloth * tableclValueUSD;
            double BGNTableCl = USDTableCl * 1.85;
            double karetaValueUSD = 9;
            double USDKareta = kareta * karetaValueUSD;
            double BGNKareta = USDKareta * 1.85;
            double USD = USDTableCl + USDKareta;
            double BGN = BGNTableCl + BGNKareta;


            Console.WriteLine($"{USD:F2} USD");
            Console.WriteLine($"{BGN:F2} BGN");
        }
    }
}
