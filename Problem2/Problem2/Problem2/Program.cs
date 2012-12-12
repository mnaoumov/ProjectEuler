using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISolver solver = new MySolver();
            Console.WriteLine(solver.Solve());
        }
    }
}
