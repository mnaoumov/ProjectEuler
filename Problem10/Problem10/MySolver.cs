using System.Linq;

namespace Problem10
{
    class MySolver
    {
        public long Solve(int max)
        {
            var sieve = new EratosthenesSieve();
            var primes = sieve.GetPrimes(max);
            return primes.Select(x => (long) x).Sum();
        }
    }
}