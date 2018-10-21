using System;

namespace _03._Longer_Line
{
    public class Longer_Line
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLineLength = CalculatePointDistance(x1, y1, x2, y2);
            double secondLineLength = CalculatePointDistance(x3, y3, x4, y4);

            if (firstLineLength >= secondLineLength)
            {
                double firstPointDistanceFromCenter = CalculatePointDistance(x1, y1);
                double secondPointDistanceFromCenter = CalculatePointDistance(x2, y2);
                if (firstPointDistanceFromCenter <= secondPointDistanceFromCenter)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                double firstPointDistanceFromCenter = CalculatePointDistance(x3, y3);
                double secondPointDistanceFromCenter = CalculatePointDistance(x4, y4);
                if (firstPointDistanceFromCenter <= secondPointDistanceFromCenter)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        public static double CalculatePointDistance(double x, double y, double x1 = 0, double y1 = 0)
        {
            return Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));
        }
    }
}
