using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Students_2._0
{
    public class Students_2_0
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
                if (StudentAlreadyAdded(students, student))
                {
                    var studentToUpdate = students.Find(s => s.FirstName == student.FirstName && s.LastName == student.LastName);
                    studentToUpdate.Age = student.Age;
                    studentToUpdate.HomeTown = student.HomeTown;
                }
                else
                {
                    students.Add(student);
                }
            }

            string city = Console.ReadLine();
            var filtered = students.Where(s => s.HomeTown == city);
            foreach (var student in filtered)
            {
                Console.WriteLine(student);
            }
        }

        private static bool StudentAlreadyAdded(List<Student> studentsList, Student studentToAdd)
        {
            if (studentsList.Any(st => st.FirstName == studentToAdd.FirstName && st.LastName == studentToAdd.LastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
