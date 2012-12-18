using System;

namespace Problem7
{
    class MySolver
    {
        public long Solve(int n)
        {
            var index = 0;
            var currentNumber = 1;
            while (index < n)
            {
                currentNumber++;
                if (IsPrime(currentNumber))
                    index++;
            }

            return currentNumber;
        }

        static bool IsPrime(int n)
        {
            var maxDivisor = Math.Sqrt(n);

            for (int i = 2; i <= maxDivisor; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}