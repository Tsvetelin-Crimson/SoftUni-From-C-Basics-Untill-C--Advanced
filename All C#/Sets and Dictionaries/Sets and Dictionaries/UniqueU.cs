using System;
using System.Collections.Generic;

namespace Sets_and_Dictionaries
{
    class UniqueU
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string username = Console.ReadLine();
                usernames.Add(username);
            }

            Console.WriteLine(string.Join("\n", usernames)); //enviroment.newline == \n


        }
    }
}
