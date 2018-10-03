using System;
using System.Numerics;

namespace _08._Snowballs
{
    public class Snowballs
    {
        public static void Main()
        {
            int snowBalls = int.Parse(Console.ReadLine());

            BigInteger bestValue = 1;
            int bestSnowballSnow = 0;
            int bestSnowballTime = 0;
            int bestSnowballQuality = 0;

            for (int i = 0; i < snowBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                int result = snowballSnow / snowballTime;
                BigInteger snowballValue = BigInteger.Pow(result, snowballQuality);
                if (snowballValue >= bestValue)
                {
                    bestValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestValue} ({bestSnowballQuality})");
        }
    }
}
