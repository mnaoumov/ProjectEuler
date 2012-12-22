namespace Problem12
{
    class MySolver
    {
        public long Solve()
        {
            long n = 1;
            while (true)
            {
                var triangleNumber = n * (n + 1) / 2;
                var amountOfDivisors = GetAmountOfDivisors(triangleNumber);
                if (amountOfDivisors >= 500)
                    return triangleNumber;
                n++;
            }
        }

        int GetAmountOfDivisors(long number)
        {
            var divisor = 2;

            var amount = 1;
            while (divisor <= number)
            {
                var divisorPower = 0;
                while (number % divisor == 0)
                {
                    divisorPower++;
                    number /= divisor;
                }
                amount *= (divisorPower + 1);
                divisor++;
            }

            return amount;
        }
    }
}