using System;
using System.Collections.Generic;

namespace NumberUtil
{
    public static class PrimeFactorsX
    {
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
