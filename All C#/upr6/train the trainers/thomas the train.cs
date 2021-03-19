using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train_the_trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string examName = "";
            double gradesSum = 0,
                allGrades = 0;

            while ((examName = Console.ReadLine()) != "Finish")
            {        
                double examSum = 0,
                    examGrade = 0;
                for (int i = 0; i < jury; i++)
                {
                    double currentGrade = double.Parse(Console.ReadLine());
                    gradesSum += currentGrade;
                    examSum += currentGrade;
                    allGrades++;                    
                }
                examGrade = examSum / jury;
                Console.WriteLine($"{examName} - {examGrade:F2}.");

            }
            double overalGrade = gradesSum / allGrades;

            Console.WriteLine($"Student's final assessment is {overalGrade:F2}.");

        }
    }
}
