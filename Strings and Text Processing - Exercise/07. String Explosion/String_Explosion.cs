using System;
using System.Text;

namespace _07._String_Explosion
{
    public class String_Explosion
    {
        public static void Main()
        {
            string inputStr = Console.ReadLine();
            
            int explosionStrength = 0;

            for (int i = 0; i < inputStr.Length; i++)
            {
                char currentChar = inputStr[i];
                if (currentChar == '>')
                {
                    explosionStrength += int.Parse(inputStr[i + 1].ToString());
                    continue;
                }
                
                if (explosionStrength > 0)
                {
                    inputStr = inputStr.Remove(i, 1);
                    i--;
                    explosionStrength--;
                }
            }

            Console.WriteLine(inputStr);
        }
    }
}
