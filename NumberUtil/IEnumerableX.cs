using System.Collections.Generic;

namespace NumberUtil
{
    public static class IEnumerableX
    {
        public static int Product(this IEnumerable<int> sequence)
        {
            var retVal = 1;
            foreach (var f in sequence) retVal *= f;
            return retVal;
        }

        public static long Product(this IEnumerable<long> sequence)
        {
            var retVal = 1L;
            foreach (var f in sequence) retVal *= f;
            return retVal;
        }

    }

}
