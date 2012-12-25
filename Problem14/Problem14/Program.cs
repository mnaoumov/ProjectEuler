using System;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxChainNumber = 0;
            var maxChainLength = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                var chainLength = GetChainLength(i);
                if (chainLength > maxChainLength)
                {
                    maxChainLength = chainLength;
                    maxChainNumber = i;
                }
            }

            Console.WriteLine(maxChainNumber);
        }

        static int GetChainLength(int n)
        {
            long temp = n;
            var chainLength = 1;
            while (temp != 1)
            {
                if (temp % 2 == 0)
                    temp /= 2;
                else
                    temp = 3 * temp + 1;
                chainLength++;
            }

            return chainLength;
        }
    }
}
