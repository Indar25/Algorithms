namespace DSA_Arrays
{
    class PrimeNumber
    {
        public bool IsPrime(int n)
        {
            if (n < 2)
                return false;

            int factor = CountFactor(n);

            if (factor == 2)
                return true;

            return false;
        }
        public int CountPrimes(int n)
        {
            bool[] arr = new bool[n];

            int count = 0;
            for (int i = 2; i * i < n; i++)
            {
                if (!arr[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        arr[j] = true;
                    }
                }
            }
            for (int i = 2; i < n; i++)
            {
                if (!arr[i])
                {
                    count++;
                }
            }
            return count;
        }
        private int CountFactor(int n)
        {
            int count = 0;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    count++;
                    if (i != n / i)
                        count++;
                }
            }
            return count;
        }
    }
}
