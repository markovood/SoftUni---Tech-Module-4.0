using System;

namespace _1._1_Data_Type_Finder__variant_
{
    public class DataTypeFinderVariant
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string dataType = string.Empty;
            while (input != "END")
            {
                dataType = GetDataType(input);
                Console.WriteLine($"{input.ToLower()} is {dataType} type");
                input = Console.ReadLine();
            }
        }

        private static string GetDataType(string input)
        {
            // solve with this example
            bool isInteger = int.TryParse(input, out int intResult);
            bool isBoolean = bool.TryParse(input, out bool boolResult);
            bool isChar = char.TryParse(input, out char charResult);
            bool isFloatingPoint = double.TryParse(input, out double floatingPointResult);

            if (isInteger)
            {
                return "integer";
            }
            else if (isFloatingPoint)
            {
                return "floating point";
            }
            else if (isChar)
            {
                return "char";
            }
            else if (isBoolean)
            {
                return "boolean";
            }
            else
            {
                return "string";
            }
        }
    }
}
