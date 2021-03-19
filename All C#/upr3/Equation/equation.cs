using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class equation
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine()), number2 = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();

            double result = 0;
            switch (@operator)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case"-":
                    result = number1 - number2;
                    break;
                case "*":
                    if(number2 != 0)
                    {
                        result = number1 * number2;
                    }
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    break;
                case "%":
                    if (number2 != 0)
                    {
                        result = number1 % number2;
                    }
                    break;
            }


            if (number2 == 0)
            {
                Console.WriteLine($"Cannot divide {number1} by zero");
            }
            else if (@operator == "+" || @operator == "-" || @operator == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{number1} {@operator} {number2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{number1} {@operator} {number2} = {result} - odd");
                }
            }
            else if (@operator == "/")
            {
                Console.WriteLine($"{number1} {@operator} {number2} = {result:F2}");
            }
            else if (@operator == "%")
            {
                Console.WriteLine($"{number1} {@operator} {number2} = {result}");
            }
        }
    }
}
