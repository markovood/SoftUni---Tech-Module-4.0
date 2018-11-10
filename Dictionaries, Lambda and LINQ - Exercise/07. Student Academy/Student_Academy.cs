using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    public class Student_Academy
    {
        public static void Main()
        {
            var studentAndGrades = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (studentAndGrades.ContainsKey(studentName))
                {
                    studentAndGrades[studentName].Add(grade);
                }
                else
                {
                    studentAndGrades.Add(studentName, new List<double>() { grade });
                }
            }

            var filtered = studentAndGrades
                .Where(s => s.Value.Average() >= 4.5)
                .OrderByDescending(gr => gr.Value.Average());
            foreach (var item in filtered)
            {
                string name = item.Key;
                double averageGrade = item.Value.Average();
                Console.WriteLine($"{name} -> {averageGrade:F2}");
            }
        }
    }
}
