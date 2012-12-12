using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    public class MySolver : ISolver
    {
        public long Solve()
        {
            const int maximum = 4000000;
            long sum = IterateFibonacci().TakeWhile(fib => fib < maximum).Where(fib => fib % 2 == 0).Sum();
            return sum;
        }

        static IEnumerable<long> IterateFibonacci()
        {
            yield return 1;
            yield return 2;

            var previous = 1;
            var current = 2;

            while (true)
            {
                var next = current + previous;
                yield return next;

                previous = current;
                current = next;
            }
        }
    }
}