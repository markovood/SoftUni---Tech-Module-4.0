using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    public class Day_of_Week
    {
        public static void Main()
        {
            string date = Console.ReadLine();
            var dateObj = DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dateObj.DayOfWeek);
        }
    }
}
