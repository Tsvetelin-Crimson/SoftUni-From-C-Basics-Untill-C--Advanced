using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double totalgrades = 0;
            int numberOfGrades = 12;
            while (numberOfGrades > 0)
            {
                double grade = double.Parse(Console.ReadLine());
                
                if (grade >= 4)
                {
                    totalgrades = totalgrades + grade;                   
                    numberOfGrades--;
                }
            }

            double endGrade = totalgrades / 12;
            Console.WriteLine($"{name} graduated. Average grade: {endGrade:F2}");
        }
    }
}
