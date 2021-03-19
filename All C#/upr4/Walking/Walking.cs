using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Walking
    {
        static void Main(string[] args)
        {
            int steps = 0;


            while (steps < 10000)
            {
                string stepsTaken = Console.ReadLine();

                if (stepsTaken == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    steps += lastSteps;
                    break;
                }
                steps += int.Parse(stepsTaken);
            }

            if (steps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                int remainingSteps = 10000 - steps;

                Console.WriteLine($"{remainingSteps} more steps to reach goal.");
            }
        }
    }
}
