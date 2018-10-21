using System;

namespace _02._Center_Point
{
    public class Center_Point
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintClosestToTheCenter(x1, y1, x2, y2);
        }

        private static void PrintClosestToTheCenter(double x1, double y1, double x2, double y2)
        {
            double firstPointDistance = CalculatePointDistance(x1, y1);
            double secondPointDistance = CalculatePointDistance(x2, y2);
            if (firstPointDistance <= secondPointDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        // optional parameters make default calculation to be distance from some point to the center of
        // Coordinate System
        public static double CalculatePointDistance(double x, double y, double x1 = 0, double y1 = 0)
        {
            return Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2));
        }
    }
}
