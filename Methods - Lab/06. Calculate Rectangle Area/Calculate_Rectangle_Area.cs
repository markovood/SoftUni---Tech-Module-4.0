using System;

namespace _06._Calculate_Rectangle_Area
{
    public class Calculate_Rectangle_Area
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = CalculateRectangleArea(width, height);
            Console.WriteLine(area);
        }

        private static double CalculateRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
