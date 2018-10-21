using System;

namespace _01._Data_Types
{
    public class Data_Types
    {
        public static void Main()
        {
            string dataType = Console.ReadLine();
            switch (dataType)
            {
                case "int":
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(ProccessInput(number));
                    break;
                case "real":
                    double realNum = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{ProccessInput(realNum):F2}");
                    break;
                case "string":
                    string someStr = Console.ReadLine();
                    Console.WriteLine(ProccessInput(someStr));
                    break;
            }
        }

        private static double ProccessInput(double realNum)
        {
            return realNum * 1.5;
        }

        private static string ProccessInput(string text)
        {
            text = text.Insert(0, "$");
            text = text.Insert(text.Length, "$");

            return text;
        }

        private static int ProccessInput(int number)
        {
            return number * 2;
        }
    }
}
