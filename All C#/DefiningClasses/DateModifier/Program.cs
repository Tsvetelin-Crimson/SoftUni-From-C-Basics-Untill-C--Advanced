using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            double res = DateModifier.GetDaysDifference(firstDate, secondDate);

            Console.WriteLine(res);

        }
    }
}
