using System;
using System.Numerics;

namespace NumberUtil
{
    /// <summary>
    /// Extensions methods of use when working with digits of numbers.
    /// </summary>
    public static class DigitsX
    {
        /// <summary>
        /// Gets number of digits of a number. Note that '-' does not count as digit: 10.NumberOfDigits() == -10.NumberOfDigits().
        /// </summary>
        /// <param name="n">Val</param>
        /// <returns>Number of digits</returns>
        public static int NumberOfDigits(this int n)
        {
            if (n >= 0)
            {
                if (n < 10) return 1;
                if (n < 100) return 2;
                if (n < 1000) return 3;
                if (n < 10000) return 4;
                if (n < 100000) return 5;
                if (n < 1000000) return 6;
                if (n < 10000000) return 7;
                if (n < 100000000) return 8;
                if (n < 1000000000) return 9;
                return 10;
            }
            else
            {
                if (n > -10) return 1;
                if (n > -100) return 2;
                if (n > -1000) return 3;
                if (n > -10000) return 4;
                if (n > -100000) return 5;
                if (n > -1000000) return 6;
                if (n > -10000000) return 7;
                if (n > -100000000) return 8;
                if (n > -1000000000) return 9;
                return 10;
            }
        }

        /// <summary>
        /// Gets number of digits of a number. Note that '-' does not count as digit: 10.NumberOfDigits() == -10.NumberOfDigits().
        /// </summary>
        /// <param name="n">Value</param>
        /// <returns>Number of digits</returns>
        public static int NumberOfDigits(this long n)
        {
            if (n >= 0)
            {
                if (n < 10L) return 1;
                if (n < 100L) return 2;
                if (n < 1000L) return 3;
                if (n < 10000L) return 4;
                if (n < 100000L) return 5;
                if (n < 1000000L) return 6;
                if (n < 10000000L) return 7;
                if (n < 100000000L) return 8;
                if (n < 1000000000L) return 9;
                if (n < 10000000000L) return 10;
                if (n < 100000000000L) return 11;
                if (n < 1000000000000L) return 12;
                if (n < 10000000000000L) return 13;
                if (n < 100000000000000L) return 14;
                if (n < 1000000000000000L) return 15;
                if (n < 10000000000000000L) return 16;
                if (n < 100000000000000000L) return 17;
                if (n < 1000000000000000000L) return 18;
                return 19;
            }
            else
            {
                if (n > -10L) return 1;
                if (n > -100L) return 2;
                if (n > -1000L) return 3;
                if (n > -10000L) return 4;
                if (n > -100000L) return 5;
                if (n > -1000000L) return 6;
                if (n > -10000000L) return 7;
                if (n > -100000000L) return 8;
                if (n > -1000000000L) return 9;
                if (n > -10000000000L) return 10;
                if (n > -100000000000L) return 11;
                if (n > -1000000000000L) return 12;
                if (n > -10000000000000L) return 13;
                if (n > -100000000000000L) return 14;
                if (n > -1000000000000000L) return 15;
                if (n > -10000000000000000L) return 16;
                if (n > -100000000000000000L) return 17;
                if (n > -1000000000000000000L) return 18;
                return 19;
            }
        }

        /// <summary>
        /// Gets number of digits of a number. Note that '-' does not count as digit: 10.NumberOfDigits() == -10.NumberOfDigits().
        /// </summary>
        /// <param name="n">Value</param>
        /// <returns>Number of digits</returns>
        public static int NumberOfDigits(this BigInteger n)
        {
            return (int)Math.Floor(BigInteger.Log10(BigInteger.Abs(n)) + 1);
        }

        /// <summary>
        /// Gets digits of a number.
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Digits</returns>
        public static int[] Digits(this BigInteger n)
        {
            if (n < 0)
            {
                throw new ArgumentException(nameof(n) + " < 0 : " + n + " < 0");
            }

            var count = n.NumberOfDigits();
            var retVal = new int[count];
            for (var i = count - 1; i >= 0; i--)
            {
                n = BigInteger.DivRem(n, 10, out BigInteger remainder);
                retVal[i] = (int)remainder;
            }

            return retVal;
        }

        /// <summary>
        /// Gets digits of a number.
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Digits</returns>
        public static int[] Digits(this int n)
        {
            if (n < 0)
            {
                throw new ArgumentException(nameof(n) + " < 0 : " + n + " < 0");
            }

            var count = n.NumberOfDigits();
            var retVal = new int[count];
            for (var i = count - 1; i >= 0; i--)
            {
                retVal[i] = n % 10;
                n /= 10;
            }

            return retVal;
        }

        /// <summary>
        /// Gets digits of a number.
        /// </summary>
        /// <param name="n">Number</param>
        /// <returns>Digits</returns>
        public static long[] Digits(this long n)
        {
            if (n < 0)
            {
                throw new ArgumentException(nameof(n) + " < 0 : " + n + " < 0");
            }

            var count = n.NumberOfDigits();
            var retVal = new long[count];
            for (var i = count - 1; i >= 0; i--)
            {
                retVal[i] = (int)(n % 10);
                n /= 10;
            }

            return retVal;
        }

        /// <summary>
        /// Convert the given digits to its base 10 number. Leftmost digit is digits[0].
        /// </summary>
        /// <param name="digits">Digits</param>
        /// <returns>Base 10 representation</returns>
        public static long Number(this long[] digits)
        {
            var retVal = 0L;

            var n = digits.Length;

            for (int i = 0, p = n - 1; i < n; i++, p--)
            {
                var d = digits[i];
                if (d < 0)
                {
                    throw new ArgumentException(nameof(digits) + "[" + i + "] < 0 : " + d + " < 0");
                }

                switch (p)
                {
                    case  0: retVal += d * 1; break;
                    case  1: retVal += d * 10; break;
                    case  2: retVal += d * 100; break;
                    case  3: retVal += d * 1000; break;
                    case  4: retVal += d * 10000; break;
                    case  5: retVal += d * 100000; break;
                    case  6: retVal += d * 1000000; break;
                    case  7: retVal += d * 10000000; break;
                    case  8: retVal += d * 100000000; break;
                    case  9: retVal += d * 1000000000; break;
                    case 10: retVal += d * 10000000000; break;
                    case 11: retVal += d * 100000000000; break;
                    case 12: retVal += d * 1000000000000; break;
                    case 13: retVal += d * 10000000000000; break;
                    case 14: retVal += d * 100000000000000; break;
                    case 15: retVal += d * 1000000000000000; break;
                    case 16: retVal += d * 10000000000000000; break;
                    case 17: retVal += d * 100000000000000000; break;
                    case 18: retVal += d * 1000000000000000000; break;
                    default: throw new OverflowException();
                }
            }

            return retVal;
        }

        /// <summary>
        /// Convert the given digits to its base 10 number. Leftmost digit is digits[0].
        /// </summary>
        /// <param name="digits">Digits</param>
        /// <returns>Base 10 representation</returns>
        public static int Number(this int[] digits)
        {
            var retVal = 0;

            var n = digits.Length;

            for (int i = 0, p = n - 1; i < n; i++, p--)
            {
                var d = digits[i];
                if (d < 0)
                {
                    throw new ArgumentException(nameof(digits) + "[" + i + "] < 0 : " + d + " < 0");
                }

                switch (p)
                {
                    case 0: retVal += d * 1; break;
                    case 1: retVal += d * 10; break;
                    case 2: retVal += d * 100; break;
                    case 3: retVal += d * 1000; break;
                    case 4: retVal += d * 10000; break;
                    case 5: retVal += d * 100000; break;
                    case 6: retVal += d * 1000000; break;
                    case 7: retVal += d * 10000000; break;
                    case 8: retVal += d * 100000000; break;
                    case 9: retVal += d * 1000000000; break;
                    default: throw new OverflowException();
                }
            }

            return retVal;
        }

    }

}
