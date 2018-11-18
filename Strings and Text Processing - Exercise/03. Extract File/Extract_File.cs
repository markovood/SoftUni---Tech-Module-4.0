using System;

namespace _03._Extract_File
{
    public class Extract_File
    {
        public static void Main()
        {
            string path = Console.ReadLine();
            int indexOfSlash  = path.LastIndexOf('\\');
            string file = path.Substring(indexOfSlash + 1);

            int indexOfLastDot = file.LastIndexOf('.');
            string fileName = file.Substring(0, indexOfLastDot);
            string fileExtension = file.Substring(indexOfLastDot + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
