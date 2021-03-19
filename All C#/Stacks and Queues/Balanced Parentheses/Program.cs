using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> leftParentheses = new Stack<char>();
            

            
            bool isBalanced = true;
            foreach (char c in input)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    leftParentheses.Push(c);
                }
                else
                {
                    if (!leftParentheses.Any())
                    {
                        isBalanced = false;
                        break;
                    }
                    char currentLeftPar = leftParentheses.Pop();

                    bool isBalancedRound = currentLeftPar == '(' && c == ')';
                    bool isBalancedSquare = currentLeftPar == '[' && c == ']';
                    bool isBalancedCurly = currentLeftPar == '{' && c == '}';

                    if (!isBalancedRound && !isBalancedCurly && !isBalancedSquare)
                    {
                        isBalanced = false;
                    }

                }


            }


            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
