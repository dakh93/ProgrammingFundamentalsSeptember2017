using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AverageGrade
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }

            public double AverageGrade => Grades.Average();


            static void Main(string[] args)
            {
                string[] fileContent =
                    File.ReadAllText(@"..\..\input.txt")
                    .Split(new [] {Environment.NewLine},StringSplitOptions.None)
                    .ToArray();
                int n = int.Parse(fileContent[0]);

                List<Student> students = new List<Student>();

                for (int i = 0; i < n; i++)
                {
                    Student student = new Student();
                    string[] input = fileContent[i+1].Split().ToArray();

                    student.Name = input[0];
                    student.Grades = input.Skip(1).Select(double.Parse).ToList();

                    students.Add(student);

                }
                students
                    .Where(s => s.AverageGrade >= 5.00)
                    .OrderBy(s => s.Name)
                    .ThenByDescending(s => s.AverageGrade)
                    .ToList()
                    .ForEach(s =>
                    File.AppendAllText(@"..\..\output.txt", s.Name + " -> " + string.Format("{0:f2}",s.AverageGrade) + Environment.NewLine));
                   
            }

        }
    }
}
