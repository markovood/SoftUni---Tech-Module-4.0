using System;
using System.Collections.Generic;

namespace _06._Replace_Repeating_Chars
{
    public class Replace_Repeating_Chars
    {
        public static void Main()
        {
            string inputStr = Console.ReadLine();
            string outputSubStr = new string(inputStr[0], 1);
            for (int i = 1; i < inputStr.Length; i++)
            {
                char currentChar = inputStr[i];
                if (currentChar != outputSubStr[outputSubStr.Length - 1])
                {
                    outputSubStr += currentChar;
                }
            }

            Console.WriteLine(outputSubStr);
        }
    }
}
