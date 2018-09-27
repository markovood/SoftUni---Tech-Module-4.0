using System;

namespace _2._English_Name_of_the_Last_Digit
{
    public class English_Name_of_the_Last_Digit
    {
        public static void Main()
        {
            int someNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(PronounceDigit(someNumber));
        }

        public static string PronounceDigit(int number)
        {
            int lastDigit = number % 10;
            switch (lastDigit)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "Invalid digit!";
            }
        }
    }
}
