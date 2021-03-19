using System;
using System.Collections.Generic;
using System.Linq;

namespace Party_Reservation_Filter_Module
{
    class PartRFM
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            List<string> filters = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] tokens = input.Split(';');
                string command = tokens[0],
                    filterType = tokens[1],
                    paramater = tokens[2];

                if (command == "Add filter")
                {
                    filters.Add($"{filterType};{paramater}");
                }
                else if (command == "Remove filter")
                {
                    filters.Remove($"{filterType};{paramater}");
                }
            }

            foreach (string filter in filters)
            {
                string[] tokens = filter.Split(';');
                string currFilter = tokens[0];
                string paramater = tokens[1];

                switch (currFilter)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(paramater)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(paramater)).ToList();

                        break;
                    case "Length":
                        people = people.Where(p => !(p.Length == int.Parse(paramater))).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(paramater)).ToList();
                        break;
                    default:
                        break;
                }


            }

            Console.WriteLine(string.Join(' ', people));
        }
    }
}
