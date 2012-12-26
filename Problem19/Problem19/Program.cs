using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            for (DateTime date = new DateTime(1901, 1, 1); date.Year <= 2000; date = date.AddMonths(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
