using System;

namespace _02._Circle_Area__Precision_12_
{
    public class Circle_Area__Precision_12
    {
        public static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double circleArea = Math.PI * radius * radius;

            Console.WriteLine($"{circleArea:F12}");
        }
    }
}
