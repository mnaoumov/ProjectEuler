namespace Problem6
{
    class MySolver2
    {
        public long Solve(int n)
        {
            // (n(n+1)/2)^2-n(n+1)(2n+1)/6 = n(n+1)/12*(3n(n+1)-2(2n+1))=n(n+1)/12*(3n^2+3n-4n-2)=n(n+1)(3n^2-n-2)/12=n(n+1)(3n+2)(n-1)/12
            return n * (n + 1) * (3 * n + 2) * (n - 1) / 12;
        }
    }
}