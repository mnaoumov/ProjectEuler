using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyCommonMultiplier(20));
        }

        public static long MyCommonMultiplier(int n)
        {
            long m = 1;
            for (int i = 1; i <= n; i++)
                m = GCM(m, i);

            return m;
        }

        static long GCM(long a, long b)
        {
            return a * b / GCD(a, b);
        }

        static long GCD(long a, long b)
        {
            while (true)
            {
                var r = a % b;
                if (r == 0)
                    return b;
                
                a = b;
                b = r;
            }
        }
    }
}
