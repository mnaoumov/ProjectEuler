using System;

namespace Problem9
{
    class RecommendedSolver
    {
        public int Solve(int sum)
        {
            /*
             * a = (m^2 - n^2)d
             * b = 2mnd
             * c = (m^2 + n^2)d
             * s = (2m^2+2mn)d=2md(m+n)
             * m,
             */
            var s2 = sum / 2;
            var mLimit = Math.Sqrt(s2);

            for (int m = 2; m <= mLimit; m++)
            {
                if (s2 % m == 0)
                {
                    var sm = s2 / m;
                    while (sm % 2 == 0)
                        sm /= 2;
                    int k = m % 2 == 1 ? m + 2 : m + 1;
                    while (k < 2 * m && k <= sm)
                    {
                        if (sm % k == 0 && GCD(k, m) == 1)
                        {
                            var d = s2 / (k * m);
                            var n = k - m;
                            var a = d * (m * m - n * n);
                            var b = 2 * d * m * n;
                            var c = d * (m * m + n * n);
                            return a * b * c;
                        }
                        k += 2;
                    }
                }
            }

            return 0;
        }

        int GCD(int n, int m)
        {
            while (m != 0)
            {
                var d = n % m;
                n = m;
                m = d;
            }

            return n;
        }
    }
}