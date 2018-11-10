using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    public class Students
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                // "{first name} {second name} {grade}"
                string[] studentInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
                students.Add(student);
            }

            students = students.OrderByDescending(x => x.Grade).ToList();
            Print(students);
        }

        private static void Print(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
