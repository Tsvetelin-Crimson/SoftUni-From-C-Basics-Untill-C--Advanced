using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    class ExamPrep
    {
        static void Main(string[] args)
        {
            int badGradeCap = int.Parse(Console.ReadLine()),
                numbOfBadGrades = 0;
            string lastTask = "";
            double combGrades = 0,
                numberOfGrades = 0;

            while (badGradeCap != numbOfBadGrades)
            {
                string task = Console.ReadLine();
                if (task == "Enough")
                {
                    break;
                }
                double grade = double.Parse(Console.ReadLine());

                if (grade <= 4)
                {
                    numbOfBadGrades++;
                }

                combGrades += grade;
                numberOfGrades++;
                lastTask = task;
            }

            if (badGradeCap == numbOfBadGrades)
            {
                Console.WriteLine($"You need a break, {badGradeCap} poor grades.");
            }
            else
            {
                double averageScore = combGrades / numberOfGrades;
                Console.WriteLine($"Average score: {averageScore:F2}");
                Console.WriteLine($"Number of problems: {numberOfGrades}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

        }
    }
}
