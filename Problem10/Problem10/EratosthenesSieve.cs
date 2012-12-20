using System;
using System.Linq;

namespace Problem10
{
    class EratosthenesSieve
    {
        public int[] GetPrimes(int max)
        {
            var primeCandidates = new bool[max + 1];
            for (int i = 0; i < max + 1; i++)
                primeCandidates[i] = true;

            primeCandidates[0] = primeCandidates[1] = false;

            var maxCandidate = Math.Sqrt(max);

            for (int candidate = 2; candidate <= maxCandidate; candidate++)
            {
                if (!primeCandidates[candidate])
                    continue;
                for (int notPrime = candidate * 2; notPrime <= max; notPrime += candidate)
                    primeCandidates[notPrime] = false;
            }

            return primeCandidates.Select((isPrime, number) => new { isPrime, number }).Where(x => x.isPrime).Select(x => x.number).ToArray();
        }
    }
}