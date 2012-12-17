using System;

namespace Problem5
{
    public class RecommendedSolver
    {
        public long Solve(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    var power = (int) Math.Floor(Math.Log(n, i));
                    result *= (int) Math.Pow(i, power);
                }
            }

            return result;
        }

        bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            var maxLimit = Math.Sqrt(n);

            for (int i = 2; i <= maxLimit; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}