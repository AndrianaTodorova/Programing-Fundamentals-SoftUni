using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Student> stGroup = new Dictionary<string, Student>();

            while (input != "end of dates")
            {
                string[] tokens = input.Split(new [] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                   List<string> dates = tokens.Skip(1).ToList();

                if (!stGroup.ContainsKey(username))
                {
                    Student student = new Student();
                    student.Username = username;

                    student.Date.AddRange(dates);
                    stGroup.Add(student.Username, student);
                }
                else
                {
                    stGroup[username].Date.AddRange(dates);
                }
              

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
          
            while (input != "end of comments")
            {
                string[] comments = input.Split('-');
                string username = comments[0];
                if (stGroup.ContainsKey(username))
                {
                    stGroup[username].Comments.Add(comments[1]);
                }

                input = Console.ReadLine();
            }
            foreach (var kvp in stGroup.OrderBy(a => a.Key))
            {
                var student = kvp.Value;

                string username = student.Username;
                List<string> comments = student.Comments;
                List<string> dates = student.Date;
                Console.WriteLine(username);
                Console.WriteLine("Comments:");
                
                if (comments.Any())
                {
                    Console.WriteLine(string.Join("\n", comments.Select(e => $"- {e}")));
                }
                Console.WriteLine("Dates attended:");
                if (dates.Any())
                {
                    
                    Console.WriteLine(string.Join("\n", dates.OrderBy(x => x).Select(e => $"-- {e}")));
                }
               

            }
        }
    }
    public class Student
    {
        public string Username { get; set; }
        public List<string> Comments { get; set; }
        public List<string> Date { get; set; }

        public Student()
        {
            this.Comments = new List<string>();
            this.Date = new List<string>();
        }
    }
}
