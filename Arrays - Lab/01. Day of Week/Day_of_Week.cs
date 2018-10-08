using System;

namespace _01._Day_of_Week
{
    public class Day_of_Week
    {
        public static void Main()
        {
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(daysOfWeek[dayNumber - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
