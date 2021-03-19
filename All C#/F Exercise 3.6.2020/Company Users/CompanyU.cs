using System;
using System.Collections.Generic;
using System.Linq;

namespace Company_Users
{
    class CompanyU
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokensOfInput = input.Split(" -> ");
                string nameCompany = tokensOfInput[0],
                    ID = tokensOfInput[1];

                if (!companies.ContainsKey(nameCompany))
                {
                    companies[nameCompany] = new List<string>();
                }

                if (!companies[nameCompany].Contains(ID))
                {
                    companies[nameCompany].Add(ID);
                }
            }

            companies = companies.OrderBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var item in companies)
            {
                Console.WriteLine($"{item.Key}\n-- " + $"{string.Join("\n-- ", item.Value)}");
            }


        }
    }
}
