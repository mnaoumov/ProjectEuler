namespace Problem6
{
    class MySolver
    {
        public long Solve(int n)
        {
            var sum = Sum(n);
            return sum * sum - SumOfSquares(n);
        }

        long SumOfSquares(int n)
        {
            return n * (n + 1) * (2 * n + 1) / 6;
        }

        long Sum(int n)
        {
            return n * (n + 1) / 2;
        }
    }
}