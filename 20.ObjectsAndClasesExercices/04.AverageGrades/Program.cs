using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                var students = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                Student student = new Student();
                string name = students[0];
                student.NameOfStudents = name;

                //student.Grades.AddRange(students.Skip(1).Select(double.Parse).ToList());

                for (int grades = 1; grades < students.Count; grades++)
                {
                    student.Grades.Add(double.Parse(students[grades]));
                }
                studentsList.Add(student);
            }
            studentsList
                .Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.NameOfStudents)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(st =>  
                        Console.WriteLine($"{st.NameOfStudents} -> {st.AverageGrade:F2}"
                        ));
        }
    }
    public class Student
    {
        public string NameOfStudents { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade => this.Grades.Average();

        public Student()
        {
            this.Grades = new List<double>();
        }
    }
}
