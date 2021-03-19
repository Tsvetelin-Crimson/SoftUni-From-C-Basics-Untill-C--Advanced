using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class SoftUniER
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();
            Dictionary<string, int> numbOfSubmissions = new Dictionary<string, int>();

            string input;

            while ((input = Console.ReadLine())!= "exam finished")
            {
                string[] tokensOfInput = input.Split('-');

                if (tokensOfInput.Length == 3)
                {
                    string name = tokensOfInput[0],
                        language = tokensOfInput[1];
                    int points = int.Parse(tokensOfInput[2]);
                    AddSubmissions(numbOfSubmissions, language);
                    AddParticipants(participants, name, points);
                }
                else
                {
                    string name = tokensOfInput[0];
                    if (participants.ContainsKey(name))
                    {
                        participants.Remove(name);
                    }
                }
            }

            participants = participants.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Results:");
            foreach (var item in participants)
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            numbOfSubmissions = numbOfSubmissions.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Submissions:");
            foreach (var item in numbOfSubmissions)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        private static void AddSubmissions(Dictionary<string, int> numbOfSubmisions, string language)
        {
            if (!numbOfSubmisions.ContainsKey(language))
            {
                numbOfSubmisions[language] = 0;
            }
            numbOfSubmisions[language]++;
        }

        private static void AddParticipants(Dictionary<string, int> participants, string name, int points)
        {
            if (!participants.ContainsKey(name))
            {
                participants[name] = points;
            }

            if (participants[name] < points)
            {
                participants[name] = points;
            }
        }
    }
}
