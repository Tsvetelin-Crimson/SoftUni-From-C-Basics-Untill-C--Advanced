using System;

namespace Bonus_Scoring_System
{
    class BonusSS
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine()),
                lectures = int.Parse(Console.ReadLine()),
                initialBonus = int.Parse(Console.ReadLine());


            double maxBonus = 0;
            int maxAttendance = 0;
            //check if attendances can be more than lectures
            for (int i = 0; i < students; i++)
            {               
                int currAttendance = int.Parse(Console.ReadLine());
                double totalBonus = (double)currAttendance / lectures * (5 + initialBonus); 

                if (totalBonus > maxBonus)
                {
                    maxBonus = Math.Round(totalBonus);
                    maxAttendance = currAttendance;
                }                                             
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
