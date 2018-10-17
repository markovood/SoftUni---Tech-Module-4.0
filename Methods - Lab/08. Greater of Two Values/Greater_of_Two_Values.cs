using System;

namespace _08._Greater_of_Two_Values
{
    public class Greater_of_Two_Values
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondInt));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
            }
        }

        private static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar.CompareTo(secondChar) >= 0)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }

        private static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }

        private static int GetMax(int firstInt, int secondInt)
        {
            if (firstInt >= secondInt)
            {
                return firstInt;
            }
            else
            {
                return secondInt;
            }
        }
    }
}
