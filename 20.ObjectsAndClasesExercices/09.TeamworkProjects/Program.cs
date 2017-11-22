using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> CreatorAndTeam = new List<Team>();
            List<string> input = new List<string>(); 

            for (int i = 0; i < n; i++)
            {
                input =Console.ReadLine()
                    .Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                 Team newTeam = new Team();
                
                if (CreatorAndTeam.Where(t => t.TeamName == input[1]).Any())
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                
                }
                if (CreatorAndTeam.Where(k => k.Creator == input[0]).Any())
                {
                    Console.WriteLine($"{input[0]} cannot create another team!");
                }
                else
                {
                    newTeam.Creator = input[0];
                    newTeam.TeamName = input[1];
                    CreatorAndTeam.Add(newTeam);
                    Console.WriteLine($"Team {newTeam.TeamName} has been created by {newTeam.Creator}!");
                }
               
            }
            
            while (input[0] != "end of assignment")
            {
                input = Console.ReadLine()
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (CreatorAndTeam.Where(t => t.TeamName == input[1]).Any())
                {
                    Console.WriteLine($"Team {input[1]} does not exist!");
                }

            }



        }
    }
    public class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string Creator { get; set; }
        public Team()
        {
            this.Members = new List<string>();
        }
    }
}
