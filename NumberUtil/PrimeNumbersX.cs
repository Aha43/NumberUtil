using System;

namespace NumberUtil
{
    /// <summary>
    /// Extensions methods of use when working with prime numbers.
    /// </summary>
    public static class PrimeNumbersX
    {
        public static PrimeNumbers PrimeNumbers(this long n) => new PrimeNumbers(n);
        public static PrimeNumbers PrimeNumbers(this int n) => new PrimeNumbers(n);

        public static bool IsPrime(this long n)
        {
            if (n < 2) return false;

            if (n < 4) return true;

            if (n % 2 == 0) return false;

            if (n < 9) return true;

            if (n % 3 == 0) return false;

            var r = (long)Math.Floor(Math.Sqrt(n));
            var f = 5L;
            while (f <= r)
            {
                if (n % f == 0 || n % (f + 2) == 0) return false;
                f += 6;
            }

            return true;
        }

        public static bool IsPrime(this int n) { return ((long)n).IsPrime(); }

    }
}
