using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            // C_40^20

            double result = 1;

            for (int i = 0; i < 20; i++)
            {
                result *= 40 - i;
                result /= 20 - i;
            }

            Console.WriteLine(result);
        }
    }
}
