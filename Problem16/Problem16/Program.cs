using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            var pow = System.Numerics.BigInteger.Pow(2, 1000);
            var sum = 0;
            while (pow != 0)
            {
                var digit = (int) (pow % 10);
                sum += digit;
                pow /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
