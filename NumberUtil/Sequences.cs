using System.Collections.Generic;

namespace NumberUtil
{
    /// <summary>
    /// Iterators over number sequences.
    /// </summary>
    public static class Sequences
    {
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
