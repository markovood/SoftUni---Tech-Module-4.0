using System;

namespace _01._Sum_Digits
{
    public class Sum_Digits
    {
        public static void Main()
        {
            string numberAsStr = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < numberAsStr.Length; i++)
            {
                int digit = int.Parse(numberAsStr[i].ToString());
                sum += digit;
            }

            Console.WriteLine(sum);
        }
    }
}
