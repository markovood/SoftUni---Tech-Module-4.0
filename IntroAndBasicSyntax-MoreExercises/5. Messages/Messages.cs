using System;
using System.Diagnostics;
using System.Text;

namespace _5._Messages
{
    public class Messages
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            // same performance as ClevererApproach
            Console.WriteLine(NativeApproach(numberOfLines)); // 00:00:00.0039313
            // same performance as NativeApproach
            Console.WriteLine(ClevererApproach(numberOfLines)); // 00:00:00.0035398
        }

        public static string NativeApproach(int numberOfLines)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < numberOfLines; i++)
            {
                int numberToConvert = int.Parse(Console.ReadLine());
                switch (numberToConvert)
                {
                    case 0:
                        result.Append(' ');
                        break;
                    case 2:
                        result.Append('a');
                        break;
                    case 22:
                        result.Append('b');
                        break;
                    case 222:
                        result.Append('c');
                        break;
                    case 3:
                        result.Append('d');
                        break;
                    case 33:
                        result.Append('e');
                        break;
                    case 333:
                        result.Append('f');
                        break;
                    case 4:
                        result.Append('g');
                        break;
                    case 44:
                        result.Append('h');
                        break;
                    case 444:
                        result.Append('i');
                        break;
                    case 5:
                        result.Append('j');
                        break;
                    case 55:
                        result.Append('k');
                        break;
                    case 555:
                        result.Append('l');
                        break;
                    case 6:
                        result.Append('m');
                        break;
                    case 66:
                        result.Append('n');
                        break;
                    case 666:
                        result.Append('o');
                        break;
                    case 7:
                        result.Append('p');
                        break;
                    case 77:
                        result.Append('q');
                        break;
                    case 777:
                        result.Append('r');
                        break;
                    case 7777:
                        result.Append('s');
                        break;
                    case 8:
                        result.Append('t');
                        break;
                    case 88:
                        result.Append('u');
                        break;
                    case 888:
                        result.Append('v');
                        break;
                    case 9:
                        result.Append('w');
                        break;
                    case 99:
                        result.Append('x');
                        break;
                    case 999:
                        result.Append('y');
                        break;
                    case 9999:
                        result.Append('z');
                        break;
                }
            }

            return result.ToString();
        }

        public static string ClevererApproach(int numberOfLines)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numberOfLines; i++)
            {
                string numberAsStr = Console.ReadLine();
                if (numberAsStr == "0")
                {
                    result.Append(' ');
                }
                else
                {
                    int digitsCount = numberAsStr.Length;
                    int mainDigit = int.Parse(numberAsStr) % 10;
                    int offset = (mainDigit - 2) * 3;
                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }
                    int letterIndex = offset + digitsCount - 1;
                    char letter = (char)('a' + letterIndex);
                    result.Append(letter);
                }
            }

            return result.ToString();
        }
    }
}
