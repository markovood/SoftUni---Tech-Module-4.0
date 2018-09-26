using System;

namespace _01.StudentInformation
{
    class StudentInformation
    {
        static void Main(string[] args)
        {
            // Name: John, Age: 15, Grade: 5.40
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averageGrade:F2}");
        }
    }
}
