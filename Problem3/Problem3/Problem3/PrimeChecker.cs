using System;
using System.Collections.Generic;

namespace Problem3
{
    class PrimeChecker
    {
        readonly List<long> _primes = new List<long>();
        long _maxChecked = 1;

        public bool IsPrime(long number)
        {
            if (_maxChecked >= number)
                return _primes.Contains(number);

            long primeLimit = (long) Math.Floor(Math.Sqrt(number));
            foreach (var prime in _primes)
            {
                if (prime <= primeLimit)
                {
                    if (number % prime == 0)
                        return false;
                }
                else
                    return true;
            }

            if (primeLimit < _maxChecked)
                return true;

            for (long i = _maxChecked + 1; i <= primeLimit; i++)
            {
                if (IsPrime(i))
                {
                    _primes.Add(i);
                    if (number % i == 0)
                        return false;
                }
                _maxChecked++;
            }

            return true;
        }
    }
}