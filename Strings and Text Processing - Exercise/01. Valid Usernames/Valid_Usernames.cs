using System;

namespace _01._Valid_Usernames
{
    public class Valid_Usernames
    {
        public static void Main()
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (var userName in userNames)
            {
                //	Has length between 3 and 16 characters
                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    // Contains only letters, numbers, hyphens and underscores
                    bool isCurrentlyValid = true;
                    foreach (var symbol in userName)
                    {
                        if (!char.IsLetterOrDigit(symbol) && !(symbol == '-') && !(symbol == '_'))
                        {
                            isCurrentlyValid = false;
                            break;
                        }
                    }

                    if (isCurrentlyValid)
                    {
                        Console.WriteLine(userName);
                    }
                }
            }
        }
    }
}
