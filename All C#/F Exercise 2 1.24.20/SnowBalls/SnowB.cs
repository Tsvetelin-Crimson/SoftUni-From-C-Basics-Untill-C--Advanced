using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SnowBalls
{
    class SnowB
    {
        static void Main(string[] args)
        {
            BigInteger numberOfInputs = BigInteger.Parse(Console.ReadLine()),
                bestSnowballSnow = 0,
                bestSnowballTime = 0,
                bestValue = 0;
            int
                bestSnowballQuality = 0;


            for (int i = 0; i < numberOfInputs; i++)
            {
                BigInteger snowballSnow = BigInteger.Parse(Console.ReadLine()),
                    snowballTime = BigInteger.Parse(Console.ReadLine());
                int
                    snowballQuality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (value > bestValue)
                {
                    bestValue = value;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestValue} ({bestSnowballQuality})");





        }
    }
}
