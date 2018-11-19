using System;
using System.Collections.Generic;

namespace _04._Morse_Code_Translator
{
    public class Morse_Code_Translator
    {
        public static void Main()
        {
            Dictionary<string, string> morseAplhpabet = new Dictionary<string, string>()
            {
                [".-"] = "A",
                ["-..."] = "B",
                ["-.-."] = "C",
                ["-.."] = "D",
                ["."] = "E",
                ["..-."] = "F",
                ["--."] = "G",
                ["...."] = "H",
                [".."] = "I",
                [".---"] = "J",
                ["-.-"] = "K",
                [".-.."] = "L",
                ["--"] = "M",
                ["-."] = "N",
                ["---"] = "O",
                [".--."] = "P",
                ["--.-"] = "Q",
                [".-."] = "R",
                ["..."] = "S",
                ["-"] = "T",
                ["..-"] = "U",
                ["...-"] = "V",
                [".--"] = "W",
                ["-..-"] = "X",
                ["-.--"] = "Y",
                ["--.."] = "Z"
            };

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string key = input[i];
                if (morseAplhpabet.ContainsKey(key))
                {
                    string value = morseAplhpabet[key];
                    input[i] = value;
                }
            }

            string decryptedMsg = string.Join("", input);
            string beautifiedMsg = decryptedMsg.Replace('|', ' ');
            Console.WriteLine(beautifiedMsg);
        }
    }
}
