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

        public static int[] Digits(this BigInteger n)
        {
            var count = n.NumberOfDigits();
            var retVal = new int[count];
            for (var i = count - 1; i >= 0; i--)
            {
                n = BigInteger.DivRem(n, 10, out BigInteger remainder);
                retVal[i] = (int)remainder;
            }

            return retVal;
        }

        public static int[] Digits(this int n)
        {
            var count = n.NumberOfDigits();
            var retVal = new int[count];
            for (var i = count - 1; i >= 0; i--)
            {
                retVal[i] = n % 10;
                n /= 10;
            }

            return retVal;
        }

        public static int[] Digits(this long n)
        {
            var count = n.NumberOfDigits();
            var retVal = new int[count];
            for (var i = count - 1; i >= 0; i--)
            {
                retVal[i] = (int)(n % 10);
                n /= 10;
            }

            return retVal;
        }

        public static long ToLong(this int[] digits)
        {
            var retVal = 0L;

            for (var i = 0; i < digits.Length; i++)
            {
                switch (i)
                {
                    case  0: retVal += digits[0]  * 1; break;
                    case  1: retVal += digits[1]  * 10; break;
                    case  2: retVal += digits[2]  * 100; break;
                    case  3: retVal += digits[3]  * 1000; break;
                    case  4: retVal += digits[4]  * 10000; break;
                    case  5: retVal += digits[5]  * 100000; break;
                    case  6: retVal += digits[6]  * 1000000; break;
                    case  7: retVal += digits[7]  * 10000000; break;
                    case  8: retVal += digits[8]  * 100000000; break;
                    case  9: retVal += digits[9]  * 1000000000; break;
                    case 10: retVal += digits[10] * 10000000000; break;
                    case 11: retVal += digits[11] * 100000000000; break;
                    case 12: retVal += digits[12] * 1000000000000; break;
                    case 13: retVal += digits[13] * 10000000000000; break;
                    case 14: retVal += digits[14] * 100000000000000; break;
                    case 15: retVal += digits[15] * 1000000000000000; break;
                    case 16: retVal += digits[16] * 10000000000000000; break;
                    case 17: retVal += digits[17] * 100000000000000000; break;
                    case 18: retVal += digits[18] * 1000000000000000000; break;
                    default: throw new OverflowException();
                }
            }

            return retVal;
        }

        public static int ToInt(this int[] digits)
        {
            var retVal = 0;

            for (var i = 0; i < digits.Length; i++)
            {
                switch (i)
                {
                    case 0: retVal += digits[0] * 1; break;
                    case 1: retVal += digits[1] * 10; break;
                    case 2: retVal += digits[2] * 100; break;
                    case 3: retVal += digits[3] * 1000; break;
                    case 4: retVal += digits[4] * 10000; break;
                    case 5: retVal += digits[5] * 100000; break;
                    case 6: retVal += digits[6] * 1000000; break;
                    case 7: retVal += digits[7] * 10000000; break;
                    case 8: retVal += digits[8] * 100000000; break;
                    case 9: retVal += digits[9] * 1000000000; break;
                    default: throw new OverflowException();
                }
            }

            return retVal;
        }

    }

}
