using System;

namespace _04._Convert_Meters_to_Kilometers
{
    public class Convert_Meters_to_Kilometers
    {
        public static void Main()
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            double distanceInKm = distanceInMeters / 1000.0;

            Console.WriteLine($"{distanceInKm:F2}");
        }
    }
}
