using System;
using System.Text;

namespace _10._Repeat_String
{
    public class Repeat_String
    {
        public static void Main()
        {
            string strToRepeat = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            string repeated = RepeatString(strToRepeat, repeatCount);
            Console.WriteLine(repeated);
        }

        private static string RepeatString(string strToRepeat, int repeatCount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < repeatCount; i++)
            {
                sb.Append(strToRepeat);
            }

            return sb.ToString();
        }
    }
}
