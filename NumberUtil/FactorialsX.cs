using System;
using System.Numerics;

namespace NumberUtil
{
    /// <summary>
    /// Extensions methods of use when computing n!.
    /// </summary>
    public static class FactorialsX
    {
        private static readonly int[]  _intFactorials  = new int[]  { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600 };
        private static readonly long[] _longFactorials = new long[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800, 39916800, 479001600, 6227020800, 87178291200, 1307674368000, 20922789888000, 355687428096000, 6402373705728000, 121645100408832000, 2432902008176640000 };

        /// <summary>
        /// Compute n!
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>Tuple with representations of the result: Value component will always be assigned but AsInt and AsLong only if result fit in an int or long.</returns>
        public static (int AsInt, long AsLong, BigInteger Value) Factorial(this int n) => Factorial((long)n);

        /// <summary>
        /// Compute n!
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>Tuple with representations of the result: Value component will always be assigned but AsInt and AsLong only if result fit in an int or long.</returns>
        public static (int AsInt, long AsLong, BigInteger Value) Factorial(this long n)
        {
            if (n < 0)
            {
                throw new ArgumentException(nameof(n) + " < 0 : " + n + " < 0");
            }

            if (n == 0)
            {
                return (1, 1, BigInteger.One);
            }
            if (n < 13)
            {
                var f = _intFactorials[n];
                return (f, f, new BigInteger(f));
            }
            if (n < 21)
            {
                var f = _longFactorials[n];
                return (0, f, new BigInteger(f));
            }

            var retVal = new BigInteger(n--);
            while (n > 1) retVal = BigInteger.Multiply(retVal, new BigInteger(n--));

            return (0, 0, retVal);
        }

    }

}
