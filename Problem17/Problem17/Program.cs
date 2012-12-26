using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            var lettersCount = 0;
            for (int i = 1; i <= 1000; i++)
            {
                var words = GetNumberInWords(i);
                lettersCount += GetLettersCount(words);
            }

            Console.WriteLine(lettersCount);
        }

        static int GetLettersCount(string words)
        {
            return words.Count(symbol => char.IsLetter(symbol));
        }

        static string GetNumberInWords(int n)
        {
            var dict = new Dictionary<int, string>
                           {
                               { 1, "one" },
                               { 2, "two" },
                               { 3, "three" },
                               { 4, "four" },
                               { 5, "five" },
                               { 6, "six" },
                               { 7, "seven" },
                               { 8, "eight" },
                               { 9, "nine" },
                               { 10, "ten" },
                               { 11, "eleven" },
                               { 12, "twelve" },
                               { 13, "thirteen" },
                               { 14, "fourteen" },
                               { 15, "fifteen" },
                               { 16, "sixteen" },
                               { 17, "seventeen" },
                               { 18, "eighteen" },
                               { 19, "nineteen" },
                               { 20, "twenty" },
                               { 30, "thirty" },
                               { 40, "forty" },
                               { 50, "fifty" },
                               { 60, "sixty" },
                               { 70, "seventy" },
                               { 80, "eighty" },
                               { 90, "ninety" },
                               { 1000, "one thousand"}
                           };

            if (dict.ContainsKey(n))
                return dict[n];

            if (n < 100)
            {
                var tens = n / 10 * 10;
                var ones = n % 10;
                return string.Format("{0}-{1}", GetNumberInWords(tens), GetNumberInWords(ones));
            }
            else
            {
                var hundreds = n / 100;
                var rest = n % 100;

                return rest == 0
                           ? string.Format("{0} hundred", GetNumberInWords(hundreds))
                           : string.Format("{0} hundred and {1}", GetNumberInWords(hundreds), GetNumberInWords(rest));
            }

        }
    }
}
