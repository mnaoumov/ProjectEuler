using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            //var solver = new MySolver();
            var solver = new MySolver2();
            Console.WriteLine(solver.Solve(100));
        }
    }
}
