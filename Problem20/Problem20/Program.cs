using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            var fact = Factorial(100);
            var digitsSum = GetDigitsSum(fact);

            Console.WriteLine(digitsSum);
        }

        static int GetDigitsSum(BigInteger n)
        {
            var sum = 0;
            while (n != 0)
            {
                sum += (int)(n % 10);
                n /= 10;
            }

            return sum;
        }

        static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;

            return factorial;
        }
    }
}
