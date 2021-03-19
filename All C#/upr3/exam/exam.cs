using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class exam
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine()), 
                minuteExam = int.Parse(Console.ReadLine()), 
                hourArrived = int.Parse(Console.ReadLine()), 
                minuteArriver = int.Parse(Console.ReadLine());

            int totalTimeExam = (hourExam * 60) + minuteExam,
                totalTimeArrived = (hourArrived * 60) + minuteArriver,
                timeDiff = totalTimeExam - totalTimeArrived;

            if (timeDiff == 0)
            {
                Console.WriteLine("On time");
            }
            else if (timeDiff > 0 && timeDiff <= 30)
            {
                timeDiff = Math.Abs(timeDiff);
                Console.WriteLine("On time");
                Console.WriteLine($"{timeDiff} minutes before the start");
            }
            else if (timeDiff > 30)
            {
                Console.WriteLine("Early");
                timeDiff = Math.Abs(timeDiff);

                if (timeDiff >= 60)
                {
                    int hoursLeft = timeDiff / 60,
                        minutesLeft = timeDiff % 60;

                    if (minutesLeft <= 9)
                    {
                        Console.WriteLine($"{hoursLeft}:0{minutesLeft} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hoursLeft}:{minutesLeft} hours before the start");

                    }
                }
                else
                {
                    Console.WriteLine($"{timeDiff} minutes before the start");

                }

            }
            else if (timeDiff < 0 && timeDiff>= -59)
            {
                timeDiff = Math.Abs(timeDiff);
                Console.WriteLine("Late");
                Console.WriteLine($"{timeDiff} minutes after the start");                    
            }
            else
            {
                timeDiff = Math.Abs(timeDiff);
                Console.WriteLine("Late");
                int hoursLeft = timeDiff / 60,
                       minutesLeft = timeDiff % 60;

                if (minutesLeft <= 9)
                {
                    Console.WriteLine($"{hoursLeft}:0{minutesLeft} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{hoursLeft}:{minutesLeft} hours after the start");

                }
            
            }
        
        }
    }
}
   
