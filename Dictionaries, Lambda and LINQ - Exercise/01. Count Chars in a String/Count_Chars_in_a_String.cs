using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    public class Count_Chars_in_a_String
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var symbolsOccurrences = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (currentChar != ' ')
                {
                    if (symbolsOccurrences.ContainsKey(currentChar))
                    {
                        symbolsOccurrences[currentChar]++;
                    }
                    else
                    {
                        symbolsOccurrences.Add(currentChar, 1);
                    } 
                }
            }

            foreach (var item in symbolsOccurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
