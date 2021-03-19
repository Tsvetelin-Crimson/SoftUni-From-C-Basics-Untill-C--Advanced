using System;
using System.Collections.Generic;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> app = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] arrInput = input.Split();
                string vloggerName = arrInput[0];
                if (arrInput[1] == "joined")
                {
                    if (!app.ContainsKey(vloggerName))
                    {
                        app[vloggerName] = new Dictionary<string, SortedSet<string>>();
                        app[vloggerName].Add("followers", new SortedSet<string>());
                        app[vloggerName].Add("following", new SortedSet<string>());
                    }



                }
                else
                {

                }


            }


        }
    }
}
