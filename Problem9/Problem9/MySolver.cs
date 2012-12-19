using System;

namespace Problem9
{
    class MySolver
    {
        public int Solve(int sum)
        {
            /*
             * a < b < c
             * a + b + c = s
             * a + b > c
             * s - c > c
             * c < s / 2
             * a < b < c < s / 2
             * a + b > s / 2
             * b > max (a, s / 2 - a)
             * b < s - a - b
             * b < (s - a) / 2
             * max (a, s / 2 - a) < b < (s - a) / 2
             * a < (s - a) / 2
             * 3a < s
             * a < s / 3
             * 
             * 1 <= a < s / 3
             * max (a, s / 2 - a) < b < (s - a) / 2
             * c = s - a - b
             */

            for (int a = 1; a < sum / 3; a++)
            {
                var m = Math.Max(a, sum / 2 - a);
                for (int b = m; b < (sum - a) / 2; b++)
                {
                    var c = sum - a - b;
                    if (a * a + b * b == c * c)
                    {
                        return a * b * c;
                    }
                }
            }

            return 0;
        }
    }
}