using System;

namespace _09._Poke_Mon
{
    public class Poke_Mon
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());  // poke power [1, 2.000.000.000]
            int M = int.Parse(Console.ReadLine());  // distance between the poke targets [1, 1.000.000]
            int Y = int.Parse(Console.ReadLine());  // exhaustionFactor [0, 9]

            double halfOfN = N / 2.0;
            int pokes = 0;
            while (N >= M)
            {
                N -= M;
                pokes++;
                bool isNExactlyHalf = N == halfOfN;
                if (isNExactlyHalf)
                {
                    if (Y > 0)
                    {
                        N = N / Y;
                    }
                }
            }

            Console.WriteLine(N);
            Console.WriteLine(pokes);
        }
    }
}
