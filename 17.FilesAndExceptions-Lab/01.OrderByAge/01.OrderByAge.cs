using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.OrderByAge
{
    class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string[] input =
                Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            List<Student> students = new List<Student>();
            while (input[0] != "End")
            {
                Student student = new Student();

                student.Name = input[0];
                student.ID = input[1];
                student.Age = int.Parse(input[2]);
                students.Add(student);

                input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            var result = students.OrderBy(st => st.Age);
            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }
             
        }
    }
}
