using System;
using System.Text;

namespace _02._Deciphering
{
    public class Deciphering
    {
        public static void Main()
        {
            string encryptedText = Console.ReadLine();
            string[] replacements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (IsValid(encryptedText))
            {
                StringBuilder partiallyDecrypted = new StringBuilder();
                for (int i = 0; i < encryptedText.Length; i++)
                {
                    partiallyDecrypted.Append((char)(encryptedText[i] - 3));
                }

                string decrypted = partiallyDecrypted.ToString().Replace(replacements[0], replacements[1]);

                Console.WriteLine(decrypted);
            }
            else
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
        }

        private static bool IsValid(string str)
        {
            foreach (var symbol in str)
            {
                if ((symbol < 100 || symbol > 125) && symbol != 35)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
