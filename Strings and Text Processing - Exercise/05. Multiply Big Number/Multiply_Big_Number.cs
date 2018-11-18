using System;
using System.Linq;

namespace _05._Multiply_Big_Number
{
    public class Multiply_Big_Number
    {
        public static void Main()
        {
            string realyBigNumber = Console.ReadLine().TrimStart('0');
            int singleDigit = int.Parse(Console.ReadLine());

            if (singleDigit == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                string product = string.Empty;
                int remainder = 0;
                int currentProductLastDigit = 0;
                for (int i = realyBigNumber.Length - 1; i >= 0; i--)
                {
                    int currentDigit = realyBigNumber[i] - '0';

                    int currentProduct = (currentDigit * singleDigit) + remainder;
                    currentProductLastDigit = currentProduct % 10;

                    product += currentProductLastDigit;
                    remainder = currentProduct / 10;
                }

                if (remainder > 0)
                {
                    product += remainder;
                }

                Console.WriteLine(string.Join("", product.Reverse()));
            }
        }
    }
}
