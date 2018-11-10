using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    public class Courses
    {
        public static void Main()
        {
            var courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] commandDetails = Console.ReadLine().Split(" : ");
                if (commandDetails[0] == "end")
                {
                    break;
                }

                string courseName = commandDetails[0];
                string studentName = commandDetails[1];
                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>() { studentName });
                }
            }

            // print the courses with their names and total registered users, ordered by the count of registered
            // users in descending order
            var ordered = courses.OrderByDescending(c => c.Value.Count);
            foreach (var item in ordered)
            {
                string courseName = item.Key;
                List<string> registeredStudents = item.Value;
                Console.WriteLine($"{courseName}: {registeredStudents.Count}");

                registeredStudents.Sort();
                foreach (var student in registeredStudents)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
