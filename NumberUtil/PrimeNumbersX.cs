using System;
using System.Collections.Generic;

namespace NumberUtil
{
    /// <summary>
    /// Extensions methods of use when working with prime numbers.
    /// </summary>
    public static class PrimeNumbersX
    {
        /// <summary>
        /// Tells if number is prime number or not.
        /// </summary>
        /// <param name="n"></param> Number to test.
        /// <returns>True if is else false</returns>
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

        /// <summary>
        /// Tells if number is prime number or not.
        /// </summary>
        /// <param name="n"></param> Number to test.
        /// <returns>True if is else false</returns>
        public static bool IsPrime(this int n) { return ((long)n).IsPrime(); }

        /// <summary>
        /// Iterator over a numbers prime factors.
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>IEnumerable over prime factors</returns>
        public static IEnumerable<int> PrimeFactors(this int n)
        {
            if (n < 2) yield break;

            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                yield return 2;
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2)
            var sqr = Math.Sqrt(n);
            for (var i = 3; i <= sqr; i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    yield return i;
                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2) yield return n;
        }

        /// <summary>
        /// Iterator over a numbers prime factors.
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>IEnumerable over prime factors</returns>
        public static IEnumerable<long> PrimeFactors(this long n)
        {
            if (n < 2) yield break;

            // Print the number of 2s that divide n 
            while (n % 2 == 0)
            {
                yield return 2L;
                n /= 2;
            }

            // n must be odd at this point. So we can 
            // skip one element (Note i = i +2) 
            var sqrt = Math.Sqrt(n);
            for (var i = 3L; i <= sqrt; i += 2)
            {
                // While i divides n, print i and divide n 
                while (n % i == 0)
                {
                    yield return i;
                    n /= i;
                }
            }

            // This condition is to handle the case whien 
            // n is a prime number greater than 2 
            if (n > 2) yield return n;
        }

    }

}
