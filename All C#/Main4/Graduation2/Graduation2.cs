using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation2
{
    class Graduation2
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalgrades = 0;
            int numberOfGrades = 0;
            int fails= 0;
            while (numberOfGrades < 12)
            {
                
                if(fails == 2)
                {
                    break;
                }
                double grade = double.Parse(Console.ReadLine());
                
                if (grade >= 4)
                {
                    totalgrades = totalgrades + grade;
                    numberOfGrades++;
                    fails = 0;
                }
                else
                {
                    fails++;
                }

                
            }
            if (numberOfGrades == 12)
            {
            double endGrade = totalgrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {endGrade:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {numberOfGrades+1} grade");
            }
        }
    }
    
}
