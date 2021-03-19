using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class Students
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Students2> list = new List<Students2>();
            for (int i = 0; i < n; i++)
            {
                string[] studentsTokens = Console.ReadLine().Split();

                Students2 newStudent = new Students2(studentsTokens[0], studentsTokens[1], studentsTokens[2]);

                list.Add(newStudent);
            }

            List<Students2> sortedList = list.OrderByDescending(a => a.Grade).ToList();
            
            Console.WriteLine(string.Join("\n", sortedList));
        }
    }

    class Students2
    {
        public Students2(string firstName, string lastName, string grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade}";
        }
    }
}
