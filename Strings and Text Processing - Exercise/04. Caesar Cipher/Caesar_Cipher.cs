using System;

namespace _04._Caesar_Cipher
{
    public class Caesar_Cipher
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string encryptedText = string.Empty;

            foreach (var symbol in text)
            {
                encryptedText += (char)(symbol + 3);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
