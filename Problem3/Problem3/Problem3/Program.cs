using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolver solver = new RecommendedSolver();
            Console.WriteLine(solver.Solve());
        }
    }
}
