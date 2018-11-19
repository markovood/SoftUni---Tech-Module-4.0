using System;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    public class Treasure_Finder
    {
        public static void Main()
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "find")
                {
                    break;
                }

                string decryptedLine = DecryptLine(line, key);

                int startIndexOfType = decryptedLine.IndexOf('&') + 1;
                int endIndexOfType = decryptedLine.IndexOf('&', startIndexOfType);
                int typeLength = endIndexOfType - startIndexOfType;
                string type = decryptedLine.Substring(startIndexOfType, typeLength);

                int startIndexOfCoord = decryptedLine.IndexOf('<') + 1;
                int endIndexOfCoord = decryptedLine.IndexOf('>');
                int coordLength = endIndexOfCoord - startIndexOfCoord;
                string coords = decryptedLine.Substring(startIndexOfCoord, coordLength);

                Console.WriteLine($"Found {type} at {coords}");
            }
        }

        private static string DecryptLine(string line, int[] key)
        {
            StringBuilder decryptedStr = new StringBuilder();
            for (int i = 0, j = 0; i < line.Length; i++, j++)
            {
                if (j > key.Length - 1)
                {
                    j = 0;
                }

                char decryptedSymbol = (char)(line[i] - key[j]);
                decryptedStr.Append(decryptedSymbol);
            }

            return decryptedStr.ToString();
        }
    }
}
