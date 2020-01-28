using System.Collections.Generic;

namespace NumberUtil
{
    /// <summary>
    /// Extensions methods of use when working with IEnumerable of numbers.
    /// </summary>
    public static class IEnumerableX
    {
        /// <summary>
        /// Computes the product of numbers.
        /// </summary>
        /// <param name="sequence">Numbers</param>
        /// <returns>Product</returns>
        public static int Product(this IEnumerable<int> sequence)
        {
            var retVal = 1;
            foreach (var f in sequence)
            {
                if (f == 0) return 0;
                retVal *= f;
            }
            
            return retVal;
        }

        /// <summary>
        /// Computes the product of numbers.
        /// </summary>
        /// <param name="sequence">Numbers</param>
        /// <returns>Product</returns>
        public static long Product(this IEnumerable<long> sequence)
        {
            var retVal = 1L;
            foreach (var f in sequence)
            {
                if (f == 0) return 0L;
                retVal *= f;
            }

            return retVal;
        }

    }

}
