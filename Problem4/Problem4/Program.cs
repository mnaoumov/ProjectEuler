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
            Console.WriteLine(My());
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
