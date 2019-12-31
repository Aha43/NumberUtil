using System;

namespace NumberUtil
{
    /// <summary>
    /// Extensions methods of use when working with polynomials.
    /// </summary>
    public static class PolynomialX
    {
        /// <summary>
        /// Evaluates.
        /// </summary>
        /// <param name="coefficients">
        /// Coefficients of the polynomial: Coefficient of first term is coefficients[n-1] where n is length of the coefficients array and coefficient of last term is coefficients[0].
        /// </param>
        /// <param name="x">Value to evaluate at</param>
        /// <returns>Evaluated value</returns>
        public static int Polynomial(this int[] coefficients, int x)
        {
            var n = (coefficients == null) ? 0 : coefficients.Length;
            if (n == 0) return 0;

            var nm1 = n - 1;
            var retVal = coefficients[nm1];
            if (nm1 == 0) return retVal;

            var nm2 = n - 2;
            retVal += coefficients[nm2] * x;
            if (nm2 == 0) return retVal;
            
            for (int i = n - 3, exp = 2; i >= 0; i--, exp++)
            {
                retVal += coefficients[i] * (int)Math.Pow(x, exp);   
            }

            return retVal;
        }

        /// <summary>
        /// Evaluates.
        /// </summary>
        /// <param name="coefficients">
        /// Coefficients of the polynomial: Coefficient of first term is coefficients[n-1] where n is length of the coefficients array and coefficient of last term is coefficients[0].
        /// </param>
        /// <param name="x">Value to evaluate at</param>
        /// <returns>Evaluated value</returns>
        public static long Polynomial(this long[] coefficients, long x)
        {
            var n = (coefficients == null) ? 0 : coefficients.Length;
            if (n == 0) return 0;

            var nm1 = n - 1;
            var retVal = coefficients[nm1];
            if (nm1 == 0) return retVal;

            var nm2 = n - 2;
            retVal += coefficients[nm2] * x;
            if (nm2 == 0) return retVal;

            for (int i = n - 3, exp = 2; i >= 0; i--, exp++)
            {
                retVal += coefficients[i] * (long)Math.Pow(x, exp);
            }

            return retVal;
        }

    }

}
