using System;

namespace Problem3
{
    class RecommendedSolver : ISolver
    {
        public long Solve()
        {
            const long number = 600851475143;
            return GetMaxPrimeFactor(number);
        }

        long GetMaxPrimeFactor(long number)
        {
            long lastFactor = 1;
            while (number % 2 == 0)
            {
                lastFactor = 2;
                number /= 2;
            }
            var factor = 3;
            var maxFactor = Math.Sqrt(number);
            while (number > 1 && factor <= maxFactor)
            {
                while (number % factor == 0)
                {
                    number /= factor;
                    maxFactor = Math.Sqrt(number);
                }

                factor += 2;
            }

            return number == 1 ? lastFactor : number;
        }
    }
}