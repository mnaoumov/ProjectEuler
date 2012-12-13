using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Recommended());
        }

        static int Recommended()
        {
            var largestPalindrome = 0;
            var a = 999;
            while (a >= 100)
            {
                int b;
                int db;
                if (a % 11 == 0)
                {
                    b = 999;
                    db = 1;
                }
                else
                {
                    b = 990;
                    db = 11;
                }

                while (b >= a)
                {
                    var m = a * b;
                    if (m <= largestPalindrome)
                        break;

                    if (IsPalindrome(m))
                        largestPalindrome = m;

                    b -= db;
                }

                a--;
            }

            return largestPalindrome;
        }

        static int My()
        {
            var max = 0;
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    var m = i * j;
                    if (IsPalindrome(m) && m > max)
                        max = m;
                }
            }

            return max;
        }

        static bool IsPalindrome(int i)
        {
            var str = i.ToString();
            var reversed = Reverse(str);

            return str == reversed;
        }

        static string Reverse(string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}
