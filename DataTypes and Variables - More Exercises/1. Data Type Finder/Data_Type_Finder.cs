using System;

namespace _1._Data_Type_Finder
{
    public class Data_Type_Finder
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string dataType = string.Empty;
            while (input != "END")
            {
                dataType = GetDataType(input);
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }
        }

        private static string GetDataType(string input)
        {
            // Integer, Floating point, Characters, Boolean, Strings
            if (input.Length == 1 && !char.IsDigit(input[0]))
            {
                return "character";
            }
            else if (input == "true" || input == "True" || input == "false" || input == "False")
            {
                return "boolean";
            }
            else if (IsIntOrFloat(input))// must come here for both cases int & float
            {
                if (input.IndexOf('.') == -1)
                {
                    return "integer";
                }
                else
                {
                    return "floating point";
                }
            }
            else
            {
                return "string";
            }
        }
        
        private static bool IsIntOrFloat(string input)
        {
            if (input[0] == '-' || char.IsDigit(input[0]))
            {
                int dotCounter = 0;
                for (int i = 1; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        continue;
                    }
                    else if (input[i] == '.' && dotCounter < 1)
                    {
                        dotCounter++;
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
