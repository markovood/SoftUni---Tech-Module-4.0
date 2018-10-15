using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    public class Encrypt__Sort_and_Print_Array
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] encryptedValues = new int[n];

            for (int i = 0; i < n; i++)
            {
                string currentStr = Console.ReadLine();
                int encryptedValue = Encrypt(currentStr);
                encryptedValues[i] = encryptedValue;
            }

            Array.Sort(encryptedValues);
            Console.WriteLine(string.Join(Environment.NewLine, encryptedValues));
        }

        private static int Encrypt(string currentStr)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int sum = 0;
            foreach (var symbol in currentStr)
            {
                if (vowels.Contains(symbol))
                {
                    sum += symbol * currentStr.Length;
                }
                else
                {
                    sum += symbol / currentStr.Length; // possible bug result might be double
                }
            }

            return sum;
        }
    }
}
