using System;

using static NumberUtil.Constants;

namespace NumberUtil
{
    /// <summary>
    /// Sum of number sequences given by their closed form formula.
    /// </summary>
    public static class ClosedForms
    {
        /// <summary>
        /// Sum of sequence of natural numbers: Sum(0, 1, 2, 3, 4... n).
        /// </summary>
        /// <param name="n">Number of terms</param>
        /// <returns>Sum</returns>
        public static int SumOfNumbers(int n) => n * (n + 1) / 2;

        /// <summary>
        /// Sum of sequence of natural numbers: Sum(0, 1, 2, 3, 4... n).
        /// </summary>
        /// <param name="n">Number of terms</param>
        /// <returns>Sum</returns>
        public static long SumOfNumbers(long n) => n * (n + 1) / 2;

        /// <summary>
        /// Sum of sequence of natural numbers squared: Sum(0, 1, 4, 9, 16, 25... n).
        /// </summary>
        /// <param name="n">Number of terms</param>
        /// <returns>Sum</returns>
        public static long SumOfSquares(int n) => n * (n + 1) * (2 * n + 1) / 6;

        /// <summary>
        /// Sum of sequence of natural numbers squared: Sum(0, 1, 4, 9, 16, 25... n).
        /// </summary>
        /// <param name="n">Number of terms</param>
        /// <returns>Sum</returns>
        public static long SumOfSquares(long n) => n * (n + 1) * (2 * n + 1) / 6;

        /// <summary>
        /// Sum of the Fibonacci sequence.
        /// </summary>
        /// <param name="n">Number of terms</param>
        /// <returns>Sum</returns>
        public static long SumOfFibonaccis(long n) => (long)Math.Floor((Math.Pow(GoldenRatio, n) / SquareRootOf5) + 0.5);

    }

}
