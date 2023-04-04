using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int regTeams = int.Parse(Console.ReadLine());

            for (int i = 1; i <= regTeams; i++)
            {
                string[] input = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);
                string creatorName = input[0];
                string teamName = input[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");

            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] comArgs = command.Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string memberName = comArgs[0];
                string teamName = comArgs[1];

                Team searchTeam = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (searchTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(t => t.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                if (teams.Any(t => t.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    continue;
                }

                searchTeam.AddMember(memberName);
            }

            List<Team> teamWithMembers = teams.Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            List<Team> teamToDisban = teams.Where(t => t.Members.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();

            foreach (Team validTeam in teamWithMembers)
            {
                Console.WriteLine($"{validTeam.TeamName}");
                Console.WriteLine($"- {validTeam.Creator}");

                foreach (string currentMember in validTeam.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {currentMember}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Team invalidTeam in teamToDisban)
            {
                Console.WriteLine($"{invalidTeam.TeamName}");
            }
        }

    }


    class Team
    {
        public Team(string teamName, string creatorName)
        {
            this.TeamName = teamName;
            this.Creator = creatorName;
            this.Members = new List<string>();

        }
        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }
    }
}
