using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                string combo = inputArr[i];
                char firstLetter = combo[0];
                char lastLetter = combo[combo.Length - 1];
                double number = int.Parse(combo.Substring(1, combo.Length - 2));

                if (char.IsUpper(firstLetter))
                {
                    number = number / (double)(firstLetter - 64);
                }
                else
                {
                    number = number * (double)(firstLetter - 96);
                }

                if (char.IsUpper(lastLetter))
                {
                    number = number - (double)(lastLetter - 64);
                }
                else
                {
                    number = number + (double)(lastLetter - 96);
                }
                sum += number;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
