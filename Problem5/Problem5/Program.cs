using System;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            //var solver = new MySolver();
            var solver = new RecommendedSolver();
            Console.WriteLine(solver.Solve(20));
        }
    }
}
