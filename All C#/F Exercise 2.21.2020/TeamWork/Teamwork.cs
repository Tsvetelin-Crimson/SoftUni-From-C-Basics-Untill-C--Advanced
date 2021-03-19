using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamWork
{
    class Teamwork
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            string input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] inputArr = input.Split('-');
                string creator = inputArr[0],
                    teamName = inputArr[1];


                if (teams.Find(a => a.TeamName == teamName) != null) // find prop is just a for cycle for the thing you're looking for
                {
                    Console.WriteLine($"Team {teamName} was already created!");                    
                    continue;
                }

                if (teams.Find(a => a.Creator == creator) != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");                  
                    continue;
                }


                Team teamToBeAdded = new Team(inputArr[0], inputArr[1]);
                teams.Add(teamToBeAdded);
                Console.WriteLine($"Team {inputArr[1]} has been created by {inputArr[0]}!");
                
            }

            ;

            while ((input = Console.ReadLine()) != "end of assignment")
            {
                string[] tokens = input.Split("->");
                string member = tokens[0],
                    teamName = tokens[1];

                if (teams.Find(a => a.TeamName == teamName) == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Find(a => a.Members.Contains(member) ||  a.Creator == member) != null)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                teams.Find(a => a.TeamName == teamName).Members.Add(member);
            }

            List<Team> disbandingTeams = teams
                .Where(a => a.Members.Count == 0)
                .OrderBy(a => a.TeamName)
                .ToList();

            teams.RemoveAll(a => a.Members.Count == 0);

            List<Team> sortedTeams = teams
                .OrderByDescending(a => a.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            foreach (Team t in sortedTeams)
            {
                Console.WriteLine(t.ToString().Trim());
            }
            Console.WriteLine("Teams to disband:");
            foreach (Team t in disbandingTeams)
            {
                Console.WriteLine(t.TeamName);
            }


        }
    }


    class Team
    {
        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
            this.Members = new List<string>();
        }


        public string Creator { get; set; }
        public string  TeamName { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            List<string> sortedMembers = this.Members
                .OrderBy(a => a)
                .ToList();


            string output = $"{this.TeamName}\n";
            output += $"- {this.Creator}\n";
            for (int i = 0; i < sortedMembers.Count; i++)
            {
                output += $"-- {sortedMembers[i]}\n";
            }
            return output;
        }


    }


}
