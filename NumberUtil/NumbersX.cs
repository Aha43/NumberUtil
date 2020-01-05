namespace NumberUtil
{
    /// <summary>
    /// Extension methods of use when working with numbers.
    /// </summary>
    public static class NumbersX
    {
        /// <summary>
        /// Tells if number is even.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>True if even else false</returns>
        public static bool IsEven(this int n) => n % 2 == 0;

        /// <summary>
        /// Tells if number is odd.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>True if odd else false</returns>
        public static bool IsOdd(this int n) => !IsEven(n);

        /// <summary>
        /// Tells if number is even.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>True if even else false</returns>
        public static bool IsEven(this long n) => n % 2 == 0;

        /// <summary>
        /// Tells if number is odd.
        /// </summary>
        /// <param name="n"></param>
        /// <returns>True if odd else false</returns>
        public static bool IsOdd(this long n) => !IsEven(n);
    }

}
