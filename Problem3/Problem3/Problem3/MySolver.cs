using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    public class MySolver : ISolver
    {
        readonly PrimeChecker _primeChecker;

        public MySolver()
        {
            _primeChecker = new PrimeChecker();
        }

        public long Solve()
        {
            const long number = 600851475143;
            return GetMaxPrimeFactor(number);
        }

        public long GetMaxPrimeFactor(long number)
        {
            long maximumPrime = (long) Math.Floor(Math.Sqrt(number));

            for (long i = 2; i <= maximumPrime; i++)
            {
                if (_primeChecker.IsPrime(i) && number % i == 0)
                    return GetMaxPrimeFactor(number / i);
            }

            return number;
        }
    }
}