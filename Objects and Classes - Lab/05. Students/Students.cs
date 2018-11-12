using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    public class Students
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();
            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "end")
                {
                    break;
                }

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];
                var student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);
            }

            string city = Console.ReadLine();
            var filtered = students.Where(s => s.HomeTown == city);
            foreach (var student in filtered)
            {
                Console.WriteLine(student);
            }
        }
    }
}
