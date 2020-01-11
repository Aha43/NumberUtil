using System.Collections.Generic;

namespace NumberUtil
{
    /// <summary>
    /// Iterators over number sequences.
    /// </summary>
    public static class Sequences
    {
        /// <summary>
        /// Natural numbers, starts with 0.
        /// </summary>
        public static IEnumerable<long> Natural
        {
            get
            {
                int n = 0;
                while (true) yield return n++;
            }
        }

        /// <summary>
        /// Squares, starts with 0, 1 and 4.
        /// </summary>
        public static IEnumerable<long> Squares
        {
            get
            {
                int n = 0;
                while (true) yield return n * n++;
            }
        }

        /// <summary>
        /// Fibonacci numbers.
        /// </summary>
        public static IEnumerable<long> Fibonacci
        {
            get
            {
                var a = 0;
                var b = 1;

                yield return a;
                while (true)
                {
                    yield return b;
                    var tmp = a;
                    a = b;
                    b = tmp + b;
                }
            }
        }

    }

}
