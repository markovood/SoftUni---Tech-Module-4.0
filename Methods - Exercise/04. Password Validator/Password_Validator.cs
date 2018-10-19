using System;

namespace _04._Password_Validator
{
    public class Password_Validator
    {
        public static void Main()
        {
            string password = Console.ReadLine();

            ValidatePassword(password);
        }

        private static void ValidatePassword(string password)
        {
            bool isValid = true;
            if (!ValidatePassLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (!ValidatePassChars(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!ValidatePassHasAtleast2Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool ValidatePassHasAtleast2Digits(string password)
        {
            // Password must have at least 2 digits
            int digitCount = 0;
            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitCount++;
                }
            }

            if (digitCount >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool ValidatePassChars(string password)
        {
            // Password must consist only of letters and digits
            foreach (var symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool ValidatePassLength(string password)
        {
            // Password must be between 6 and 10 characters
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
